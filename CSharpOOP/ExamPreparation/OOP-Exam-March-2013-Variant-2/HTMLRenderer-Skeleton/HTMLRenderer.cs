using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
    public class HTMLElement : IElement
    {
        public virtual string Name { get; set; }
        public virtual string TextContent { get; set; }
        protected ICollection<IElement> childElements;

        public HTMLElement(string name)
            : this(name, null)
        {
        }

        public HTMLElement(string name, string textContent)
        {
            this.Name = name;
            this.TextContent = textContent;
            this.childElements = new List<IElement>();
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.AppendFormat("<{0}>", this.Name);
            }
            if (this.TextContent != null)
            {
                string renderedContext = RenderTextContent();
                output.Append(renderedContext);
            }
            if (this.ChildElements.Count() != 0)
            {
                foreach (var element in this.ChildElements)
                {
                    output.AppendFormat(element.ToString());
                }
            }
            if (this.Name != null)
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }
        private string RenderTextContent()
        {
            var info = new StringBuilder();
            foreach (var ch in this.TextContent)
            {
                if (ch == '<')
                {
                    info.Append("&lt;");
                }
                else if (ch == '>')
                {
                    info.Append("&gt;");
                }
                else if (ch == '&')
                {
                    info.Append("&amp;");
                }
                else
                {
                    info.Append(ch);
                }
            }
            return info.ToString();
        }
        public override string ToString()
        {
            var info = new StringBuilder();
            this.Render(info);
            return info.ToString();
        }
    }

    public class Table : HTMLElement, ITable
    {
        private IElement[,] tableContent;
        private int rows;
        private int cols;
        public Table(int rows, int cols)
            : base("table")
        {
            this.rows = rows;
            this.cols = cols;
            this.tableContent = new IElement[this.rows, this.cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.tableContent[row, col];
            }
            set
            {
                this.tableContent[row, col] = value;
            }
        }
        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);
            for (int i = 0; i < this.tableContent.GetLength(0); i++)
            {
                output.Append("<tr>");
                for (int j = 0; j < this.tableContent.GetLength(1); j++)
                {
                    output.AppendFormat("<td>{0}</td>", this.tableContent[i, j]);
                }
                output.Append("</tr>");
            }
            output.AppendFormat("</{0}>", this.Name);
        }
    }

    public interface IElement
    {
        string Name { get; }
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
        void Render(StringBuilder output);
        string ToString();
    }

    public interface ITable : IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }

    public interface IElementFactory
    {
        IElement CreateElement(string name);
        IElement CreateElement(string name, string content);
        ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new HTMLElement(name);
        }

        public IElement CreateElement(string name, string content)
        {
            return new HTMLElement(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new Table(rows, cols);
        }
    }

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}

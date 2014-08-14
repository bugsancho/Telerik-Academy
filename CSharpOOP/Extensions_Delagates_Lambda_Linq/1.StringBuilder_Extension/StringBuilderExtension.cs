using System;
using System.Text;
//StringBuilder extension class that implements the substring method that takes one or two arguments, 
//respectivly index and length of the substring, and only the initial index of the substring
public static class StringBuilderExtension
{
    public static StringBuilder Substring(this StringBuilder text, int index, int length)
    {
        if (text.Length >= index + length && index >= 0 && length > 0 && text.Length != 0)
        {
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                newText.Append(text[index + i]);
            }
            return newText;
        }
        else if (length <= 0)
        {
            throw new ArgumentException("Substring length cannot be less or equal to zero!");
        }
        else if (text.Length == 0)
        {
            throw new ArgumentNullException();
        }
        else
        {
            throw new ArgumentOutOfRangeException("Invalid index and substring length!");
        }
    }
  
    public static StringBuilder Substring(this StringBuilder text, int index)
    {
       return Substring(text, index, text.Length - index);
        //if (text.Length > index && index >= 0 && text.Length != 0)
        //{
        //    StringBuilder newText = new StringBuilder();
        //    for (int i = index; i < text.Length; i++)
        //    {
        //        newText.Append(text[i]);
        //    }

        //    return newText;
        //}
        //else if (text.Length == 0)
        //{
        //    throw new ArgumentNullException();
        //}
        //else
        //{
        //    throw new ArgumentOutOfRangeException("Invalid index and substring length!");
        //}
    }
  
}

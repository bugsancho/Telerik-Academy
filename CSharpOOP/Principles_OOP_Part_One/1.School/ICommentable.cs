using System;
using System.Collections.Generic;
interface ICommentable
{
    List<string> Comments { get; set; }
    void Comment(string comment);
    //List<string> GetComments();
    void PrintComments();
}

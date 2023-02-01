
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering
{
    internal class _2
    {

    //    try
    //    {
    //        Dimond(5);
    //}
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }



void Dimond(int length)
{

    string strTop = "";
    string strBottom = "";
    int centerP = (length + 1);
    int centerN = (length + 1);

    for (int i = 1; i <= length; i++) //height
    {
        string tmpLine = "";

        for (int j = 1; j <= length * 2; j++) //width
        {
            if (centerP == j || centerN == j) { tmpLine += "#"; }
            //if (j >= centerN && j <= centerP) { tmpLine += "#"; } //מלא
            else { tmpLine += " "; }
        }
        tmpLine += "\n"; //line end

        //עיקרון הסימטריה
        strTop += tmpLine;
        if (i != length)
            strBottom = tmpLine + strBottom;

        centerP++;
        centerN--;
    }

    Console.WriteLine(strTop + strBottom);
}






string Line(int width)
{
    string str = "##";
    for (int j = 1; j <= width; j++)
        str += " #";
    str += "#";

    return str += "\n";

}

void Rectangle2(int? width, int? height)
{
    width -= 2;
    height -= 2;
    /*
    if (width is int && height is int) {
    int width = (int)widthObj;
    int height = (int)heightObj;
    }
    */
    if (width < 0 || height < 0)
        throw new ArgumentException(
            message: "Error: Recntangle Cant accept Negative or 0,1 values"
            );
    if (width >= 31 || height >= 51)
        throw new ArgumentException(
            message: "Error: Recntangle Cant accept values of width bigger then 50 and height bigger then 30"
            );
    if (width == null || height == null)
        throw new ArgumentException(
            message: "Error: Recntangle Cant accept null values"
            );
    string str = "";

    str += Line((int)width);
    for (int i = 1; i <= height; i++)
    {
        str += "# ";
        for (int j = 1; j <= width; j++)
            str += "  ";


        str += "#";
        str += "\n";

    }
    str += Line((int)width);
    Console.WriteLine(str);
}

    }
}


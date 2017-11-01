using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Description:

//Write simple .camelCase method (camel_case function in PHP or CamelCase in C#) for strings. All words must have their first letter capitalized without spaces.

//For instance:

//"hello case".camelCase() => HelloCase
//"camel case word".camelCase() => CamelCaseWord

//best solution:
//using System.Globalization;
//namespace Kata
//{
//    public static class Problem
//    {
//        public static string CamelCase(this string str)
//        {
//             string capsMe = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
//             return capsMe.Replace(" ", "");
//        }
//    }
//}




namespace Codewars_CamelCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CamelCase(string input)
        {
            List<char> chars = new List<char>();

            for (int p = 0; p < input.Length; p++)
            {
                chars.Add(input[p]);
            
            }

            if (input.Length>0)
            chars[0] = Convert.ToChar(chars[0].ToString().ToUpper());

            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i] == ' ' && i < chars.Count - 1) //.Equals(" ")
                {
                    chars[i + 1] = Convert.ToChar(chars[i+1].ToString().ToUpper());
                }
            }

            input = string.Join(string.Empty, chars);
            
            input = input.Replace(" ", string.Empty);

                return input;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox_output.Text = CamelCase(textBox_input.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            




        }

        private void button1_Click(object sender, EventArgs e)
      
                int main()
                {
                    int marks;

                    printf("Enter your marks between 0-100\n");
                    scanf("%d", &marks);
                    /* Using if else ladder statement to print
                       Grade of a Student */
                    if (marks >= 90)
                    {
                        /* Marks between 90-100 */
                        printf("YOUR GRADE : A\n");
                    }
                    else if (marks >= 70 && marks < 90)
                    {
                        /* Marks between 70-89 */
                        printf("YOUR GRADE : B\n");
                    }
                    else if (marks >= 50 && marks < 70)
                    {
                        /* Marks between 50-69 */
                        printf("YOUR GRADE : C\n");
                    }
                    else
                    {
                        /* Marks less than 50 */
                        printf("YOUR GRADE : Failed\n");
                    }

                    fetch();
                    return (0);
                }








        }

        private void txtNum4_Click(object sender, EventArgs e)
        {

        }
    }
}

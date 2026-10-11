using System;
using System.Drawing;
using System.Windows.Forms;

namespace Barajas_Exam_GUI
{
    public class TicketCalculatorGUI
    {
        public static Form TicketWindow = new Form();
        public static TextBox classAinput;
        public static TextBox classBinput;
        public static TextBox classCinput;
        public static TextBox totalTickets;
        public static TextBox revSum;
        public static TextBox ticketsSum;
        public static TextBox transactionsSum;
        public static TextBox aRev;
        public static TextBox bRev;
        public static TextBox cRev;
        public static TextBox totalRev;
        
        public static int numTransaction = 0;
        public static double overallRev = 0.0;
        public static int overallTickets = 0;
        
        public static void Main(string[] args)
        {
            
            
            Panel inputPanel = new Panel();

            Label instructions = new Label();
            instructions.Text = "Enter the number of tickets sold for each class of seats.";
            instructions.Location = new Point(8, 16);
            instructions.Size = new Size(300, 20);
            
            classAinput = new TextBox();
            Label l1 = new Label();
            l1.Text = "Class A:";
            l1.Size = new Size(100, 20);
            l1.Location = new Point(16, 45);
            classAinput.Location = new Point(130, 45);
            classAinput.Size = new Size(100, 20);
            
            classBinput = new TextBox();
            Label l2 = new Label();
            l2.Text = "Class B:";
            l2.Size = new Size(100, 20);
            l2.Location = new Point(16, 69);
            classBinput.Location = new Point(130, 69);
            classBinput.Size = new Size(100, 20);
            
            classCinput = new TextBox();
            Label l3 = new Label();
            l3.Text = "Class C:";
            l3.Size = new Size(100, 20);
            l3.Location = new Point(16, 95);
            classCinput.Location = new Point(130, 95);
            classCinput.Size = new Size(100, 20);
            
            totalTickets = new TextBox();
            Label total = new Label();
            total.Text = "Total Tickets:";
            total.Size = new Size(100, 20);
            total.Location = new Point(16, 121);
            totalTickets.Location = new Point(130, 121);
            totalTickets.Size = new Size(100, 20);
            totalTickets.ReadOnly = true;

            Label inputTitle = new Label();
            inputTitle.Text = "Tickets Sold";
            inputTitle.Location = new Point(0,0);
            
            inputPanel.BorderStyle = BorderStyle.FixedSingle;
            inputPanel.Location = new Point(20, 20);
            inputPanel.Size = new Size(310, 160);
            inputPanel.Margin = new Padding(20);
            inputPanel.Controls.Add(instructions);
            inputPanel.Controls.Add(l1);
            inputPanel.Controls.Add(classAinput);
            inputPanel.Controls.Add(l2);
            inputPanel.Controls.Add(classBinput);
            inputPanel.Controls.Add(l3);
            inputPanel.Controls.Add(classCinput);
            inputPanel.Controls.Add(total);
            inputPanel.Controls.Add(totalTickets);
            inputPanel.Controls.Add(inputTitle);
            
            Panel summaryPanel = new Panel();
            
            Label summaryTitle = new Label();
            summaryTitle.Text = "Summary";
            summaryTitle.Location = new Point(0,0);
            
            revSum = new TextBox();
            Label sum1 = new Label();
            sum1.Text = "Sum of Revenue:";
            sum1.Size = new Size(100, 20);
            sum1.Location = new Point(16, 16);
            revSum.Location = new Point(130, 16);
            revSum.Size = new Size(100, 20);
            revSum.ReadOnly = true;
            
            ticketsSum = new TextBox();
            Label sum2 = new Label();
            sum2.Text = "Sum of Tickets:";
            sum2.Size = new Size(100, 20);
            sum2.Location = new Point(16, 40);
            ticketsSum.Location = new Point(130, 40);
            ticketsSum.Size = new Size(100, 20);
            ticketsSum.ReadOnly = true;
            
            transactionsSum = new TextBox();
            Label sum3 = new Label();
            sum3.Text = "Transactions:";
            sum3.Size = new Size(100, 20);
            sum3.Location = new Point(16, 64);
            transactionsSum.Location = new Point(130, 64);
            transactionsSum.Size = new Size(100, 20);
            transactionsSum.ReadOnly = true;
            
            summaryPanel.BorderStyle = BorderStyle.FixedSingle;
            summaryPanel.Location = new Point(20, 200);
            summaryPanel.Size = new Size(260, 100);
            summaryPanel.Margin = new Padding(20);
            summaryPanel.Controls.Add(sum1);
            summaryPanel.Controls.Add(revSum);
            summaryPanel.Controls.Add(sum2);
            summaryPanel.Controls.Add(ticketsSum);
            summaryPanel.Controls.Add(sum3);
            summaryPanel.Controls.Add(transactionsSum);
            summaryPanel.Controls.Add(summaryTitle);
            
            
            Panel revenuePanel = new Panel();
            
            Label revenueTitle = new Label();
            revenueTitle.Text = "Revenue Generated";
            revenueTitle.Location = new Point(0,0);
            revenueTitle.Size = new Size(200, 20);
            
            aRev = new TextBox();
            Label c1 = new Label();
            c1.Text = "Class A:";
            c1.Size = new Size(100, 20);
            c1.Location = new Point(16, 45);
            aRev.Location = new Point(130, 45);
            aRev.Size = new Size(100, 20);
            aRev.ReadOnly = true;
            
            bRev = new TextBox();
            Label c2 = new Label();
            c2.Text = "Class B:";
            c2.Size = new Size(100, 20);
            c2.Location = new Point(16, 69);
            bRev.Location = new Point(130, 69);
            bRev.Size = new Size(100, 20);
            bRev.ReadOnly = true;
            
            cRev = new TextBox();
            Label c3 = new Label();
            c3.Text = "Class C:";
            c3.Size = new Size(100, 20);
            c3.Location = new Point(16, 95);
            cRev.Location = new Point(130, 95);
            cRev.Size = new Size(100, 20);
            cRev.ReadOnly = true;
            
            totalRev = new TextBox();
            Label revLabel = new Label();
            revLabel.Text = "Total Revenue:";
            revLabel.Size = new Size(100, 20);
            revLabel.Location = new Point(16, 121);
            totalRev.Location = new Point(130, 121);
            totalRev.Size = new Size(100, 20);
            totalRev.ReadOnly = true;
            
            revenuePanel.BorderStyle = BorderStyle.FixedSingle;
            revenuePanel.Location = new Point(350, 20);
            revenuePanel.Size = new Size(270, 160);
            revenuePanel.Margin = new Padding(20);
            revenuePanel.Controls.Add(c1);
            revenuePanel.Controls.Add(aRev);
            revenuePanel.Controls.Add(c2);
            revenuePanel.Controls.Add(bRev);
            revenuePanel.Controls.Add(c3);
            revenuePanel.Controls.Add(cRev);
            revenuePanel.Controls.Add(revLabel);
            revenuePanel.Controls.Add(totalRev);
            revenuePanel.Controls.Add(revenueTitle);


            Button calcBtn = new Button();
            calcBtn.Size = new Size(100, 60);
            calcBtn.Location = new Point(300, 240);
            calcBtn.Text = "Calculate Revenue";
            calcBtn.Click += Calculate;
            
            Button clearBtn = new Button();
            clearBtn.Size = new Size(100, 60);
            clearBtn.Location = new Point(410, 240);
            clearBtn.Text = "Clear";
            clearBtn.Click += Clear;
            
            Button exitBtn = new Button();
            exitBtn.Size = new Size(100, 60);
            exitBtn.Location = new Point(520, 240);
            exitBtn.Text = "Exit";
            exitBtn.Click += Exit;
            
            TicketWindow.Text = "Baseball Revenue Calculator";
            TicketWindow.Padding = new Padding(200);
            TicketWindow.FormBorderStyle = FormBorderStyle.FixedDialog;
            TicketWindow.Size = new Size(680,380);
            
            TicketWindow.AcceptButton = calcBtn;
            TicketWindow.CancelButton = exitBtn;
            
            TicketWindow.HelpButton = true;
            TicketWindow.Controls.Add(inputPanel);
            TicketWindow.Controls.Add(summaryPanel);
            TicketWindow.Controls.Add(revenuePanel);
            TicketWindow.Controls.Add(calcBtn);
            TicketWindow.Controls.Add(clearBtn);
            TicketWindow.Controls.Add(exitBtn);
            
            TicketWindow.ShowDialog();
            

        }

        public static void Calculate(object sender, EventArgs e)
        {
            int aTickets;
            int bTickets;
            int cTickets;
            int numTickets;
            double collectiveRev = 0.0;
            
            const int CLASSAPRICE = 15;
            const int CLASSBPRICE = 12;
            const int CLASSCPRICE = 9;
            
            if (classAinput.Text != "" && classBinput.Text != "" && classCinput.Text != "")
            {
                try
                {
                    aTickets = Convert.ToInt32(classAinput.Text);
                    bTickets = Convert.ToInt32(classBinput.Text);
                    cTickets = Convert.ToInt32(classCinput.Text);
                    numTickets = aTickets + bTickets + cTickets;
                    
                    aRev.Text = "$" + (aTickets * CLASSAPRICE).ToString("f2");
                    bRev.Text = "$" + (bTickets * CLASSBPRICE).ToString("f2");
                    cRev.Text = "$" + (cTickets * CLASSCPRICE).ToString("f2");
                    totalTickets.Text = "" + numTickets;

                    collectiveRev = aTickets * CLASSAPRICE + bTickets * CLASSBPRICE + cTickets * CLASSCPRICE;
                    totalRev.Text = "$" + collectiveRev.ToString("f2");
                    
                    numTransaction++;
                    overallTickets += numTickets;
                    overallRev += collectiveRev;
                    
                    revSum.Text = "$" + overallRev.ToString("f2");
                    ticketsSum.Text = "" + overallTickets;
                    transactionsSum.Text = "" + numTransaction;

                    classAinput.Text = "";
                    classBinput.Text = "";
                    classCinput.Text = "";
                    classAinput.Focus();
                }
                catch (InvalidCastException E)
                {
                    Console.WriteLine(E.Message);
                }
            }

            
            
        }
        
        public static void Clear(object sender, EventArgs e)
        {
            classAinput.Text = "";
            classBinput.Text = "";
            classCinput.Text = "";
            totalTickets.Text = "";
            totalRev.Text = "";
            aRev.Text = "";
            bRev.Text = "";
            cRev.Text = "";
        }
        
        public static void Exit(object sender, EventArgs e)
        {
            TicketWindow.Close();
        }

    }
    
    
    
}
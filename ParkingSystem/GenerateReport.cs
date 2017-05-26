using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using sharpPDF;
using sharpPDF.Fonts;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Program.ConnectionString);
        SqlCommand commandCard;
        SqlCommand commandFine;
        SqlCommand commandCash2;
        SqlCommand commandCash4;
        SqlCommand commandCashb;
        SqlCommand commandCount2InToday;
        SqlCommand commandCount2InOld;
        SqlCommand commandCount4InToday;
        SqlCommand commandCount4InOld;
        SqlCommand commandCountBInToday;
        SqlCommand commandCountBInOld;

        DateTime startDate;
        DateTime endDate;
        DateTime today;

        bool Flag = false;

        double totalCash = 0;

        private void GenerateReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            string StringStartDate = dateTimePickerStartDate.Text + " 12:00:00 AM";
            string StringEndDate = dateTimePickerEndDate.Text + " 11:59:59 PM";
            startDate = Convert.ToDateTime(StringStartDate);
            endDate = Convert.ToDateTime(StringEndDate);

            if (startDate <= endDate)
            {
                FetchReport();
                Flag = true;
            }
            else
            {
                toolStripStatusLabelStatus.Text = "INVALID DATE";
            }
        }
        int top = 780;
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            buttonFetch_Click(this, new EventArgs());
            if (Flag)
            {
                today = DateTime.Now;
                SaveFileDialog SaveFile = new SaveFileDialog();
                SaveFile.Filter = "PDF|*.pdf";
                SaveFile.Title = "Save Report";
                SaveFile.ShowDialog();
                if (SaveFile.FileName != "")
                {
                    pdfDocument myDoc = new pdfDocument("Report", "ME");
                    pdfPage myPage = myDoc.addPage();
                    myPage.drawRectangle(10, top, 600, top - 770, new pdfColor(0, 0, 0), new pdfColor(255, 255, 255));
                    myPage.addText("DATE : " + today.ToString(), 450, top - 20, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("LOCATION : " + Program.Location, 450, top - 35, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("REVENUE REPORT", 230, top - 60, myDoc.getFontReference("Helvetica"), 20);
                    myPage.drawLine(218, top - 70, 425, top - 70);
                    myPage.addText("DURATION ( " + startDate.ToString() + " - " + endDate.ToString() + " ) ", 154, top - 85, myDoc.getFontReference("Helvetica"), 12);
                    myPage.addText("TOTAL AMOUNT COLLECTED", 50, top - 125, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("Rs. " + textBoxTotalR.Text.Trim() + " Only", 350, top - 125, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("AMOUNT COLLECTED FROM PERMANENT CARD", 50, top - 145, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("Rs. " + textBoxCardR.Text.Trim() + " Only", 350, top - 145, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("AMOUNT COLLECTED FROM TEMPEROARY CARD", 50, top - 165, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("Rs. " + totalCash.ToString() + " Only", 350, top - 165, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("TWO WHEELERS ", 80, top - 185, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("Rs. " + textBoxCashTwoR.Text.Trim() + " Only", 350, top - 185, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("FOUR WHEELERS", 80, top - 205, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("Rs. " + textBoxCashFourR.Text.Trim() + " Only", 350, top - 205, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("BICYCLES", 80, top - 225, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("Rs. " + textBoxCashByR.Text.Trim() + " Only", 350, top - 225, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("AMOUNT COLLECTED FROM FINE", 50, top - 245, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("Rs. " + textBoxFineR.Text.Trim() + " Only", 350, top - 245, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("VEHICLE REPORT", 230, top - 310, myDoc.getFontReference("Helvetica"), 20);
                    myPage.drawLine(218, top - 320, 425, top - 320);
                    myPage.addText("DURATION ( " + startDate.ToString() + " - " + endDate.ToString() + " ) ", 154, top - 335, myDoc.getFontReference("Helvetica"), 12);
                    myPage.addText("TOTAL VEHICLES", 50, top - 375, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText(textBoxTotalIn.Text.Trim() + " Only", 350, top - 375, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("FOUR WHEELERS", 50, top - 395, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText(textBoxFourIn.Text.Trim() + " Only", 350, top - 395, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("TWO WHILLERS", 50, top - 415, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText(textBoxTwoIn.Text.Trim() + " Only", 350, top - 415, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText("BICYCLES ", 50, top - 435, myDoc.getFontReference("Helvetica"), 10);
                    myPage.addText(textBoxByIn.Text.Trim() + " Only", 350, top - 435, myDoc.getFontReference("Helvetica"), 10);
                    int count = 20;
                    int marker = top - 125;
                    for (int i = 0; i < 7; i++)
                    {
                        myPage.addText(" : ", 320, (marker), myDoc.getFontReference("Helvetica"), 10);
                        marker -= count;
                    }
                    marker = top - 375;
                    for (int i = 0; i < 4; i++)
                    {
                        myPage.addText(" : ", 320, (marker), myDoc.getFontReference("Helvetica"), 10);
                        marker -= count;
                    }
                    myDoc.createPDF(@SaveFile.FileName);
                    myPage = null;
                    myDoc = null;
                    toolStripStatusLabelStatus.Text = "DONE";
                }
            }
            
        }

        private void FetchReport()
        {
            // Computing money
            double moneyTotal, moneyCard, moneyFine, moneyCash2, moneyCash4, moneyCashb = 0;

            connection = new SqlConnection(Program.ConnectionString);
            SqlParameter Card = new SqlParameter("@Card", SqlDbType.Money);
            SqlParameter Fine = new SqlParameter("@Fine", SqlDbType.Money);
            SqlParameter Cash2 = new SqlParameter("@Cash2", SqlDbType.Money);
            SqlParameter Cash4 = new SqlParameter("@Cash4", SqlDbType.Money);
            SqlParameter Cashb = new SqlParameter("@Cashb", SqlDbType.Money);
            Card.Direction = ParameterDirection.Output;
            Fine.Direction = ParameterDirection.Output;
            Cash2.Direction = ParameterDirection.Output;
            Cash4.Direction = ParameterDirection.Output;
            Cashb.Direction = ParameterDirection.Output;
            commandCard = new SqlCommand("select @Card = sum(Ammount) from recharge where time > '" + startDate.ToString() + "' and time < '"+endDate.ToString()+"' and Location = '" + Program.Location + "' ", connection);
            commandFine = new SqlCommand("select @Fine = sum(Ammount) from fine where time > '" + startDate.ToString() + "' and time < '" + endDate.ToString() + "' and Location = '" + Program.Location + "' ", connection);
            commandCash2 = new SqlCommand("select @Cash2 = sum(Ammount) from cash where time > '" + startDate.ToString() + "' and time < '" + endDate.ToString() + "' and  Location = '" + Program.Location + "' and VType = '2' ", connection);
            commandCash4 = new SqlCommand("select @Cash4 = sum(Ammount) from cash where time > '" + startDate.ToString() + "' and time < '" + endDate.ToString() + "' and Location = '" + Program.Location + "' and VType = '4' ", connection);
            commandCashb = new SqlCommand("select @Cashb = sum(Ammount) from cash where time > '" + startDate.ToString() + "' and time < '" + endDate.ToString() + "' and Location = '" + Program.Location + "' and VType = 'B' ", connection);
            commandCard.Parameters.Add(Card);
            commandFine.Parameters.Add(Fine);
            commandCash2.Parameters.Add(Cash2);
            commandCash4.Parameters.Add(Cash4);
            commandCashb.Parameters.Add(Cashb);

            // Computing count

            //
            //
            // FYI -- Count2InToday is current vehicle number in parking
            // FYI -- Count2inOld is exited vehicles also considered in today in
            //
            //
            int count2InToday, count2InOld, count4InToday, count4InOld, countBInToday, countBInOld, countTotalIn, countTotalOut = 0;

            SqlParameter Count2InToday = new SqlParameter("@count2InToday", SqlDbType.Int);
            SqlParameter Count2InOld = new SqlParameter("@count2InOld", SqlDbType.Int);
            SqlParameter Count4InToday = new SqlParameter("@count4InToday", SqlDbType.Int);
            SqlParameter Count4InOld = new SqlParameter("@count4InOld", SqlDbType.Int);
            SqlParameter CountBInToday = new SqlParameter("@countBInToday", SqlDbType.Int);
            SqlParameter CountBInOld = new SqlParameter("@countBInOld", SqlDbType.Int);
            Count2InToday.Direction = ParameterDirection.Output;
            Count2InOld.Direction = ParameterDirection.Output;
            Count4InToday.Direction = ParameterDirection.Output;
            Count4InOld.Direction = ParameterDirection.Output;
            CountBInToday.Direction = ParameterDirection.Output;
            CountBInOld.Direction = ParameterDirection.Output;
            commandCount2InToday = new SqlCommand("select @count2InToday = count(RFID) from today where InTime > '" + startDate.ToString() + "' and InTime < '" + endDate.ToString() + "' and VType = '2' and Location = '" + Program.Location + "' ", connection);
            commandCount2InOld = new SqlCommand("select @count2InOld = count(RFID) from old where InTime > '" + startDate.ToString() + "' and InTime < '" + endDate.ToString() + "' and VType = '2' and Location = '" + Program.Location + "' ", connection);
            commandCount4InToday = new SqlCommand("select @count4InToday = count(RFID) from today where InTime > '" + startDate.ToString() + "' and InTime < '" + endDate.ToString() + "' and  VType = '4' and Location = '" + Program.Location + "' ", connection);
            commandCount4InOld = new SqlCommand("select @count4InOld = count(RFID) from old where InTime > '" + startDate.ToString() + "' and InTime < '" + endDate.ToString() + "' and VType = '4' and Location = '" + Program.Location + "' ", connection);
            commandCountBInToday = new SqlCommand("select @countBInToday = count(RFID) from today where InTime > '" + startDate.ToString() + "' and InTime < '" + endDate.ToString() + "' and VType = 'B' and Location = '" + Program.Location + "' ", connection);
            commandCountBInOld = new SqlCommand("select @countBInOld = count(RFID) from old where InTime > '" + startDate.ToString() + "' and InTime < '" + endDate.ToString() + "' and VType = 'B' and Location = '" + Program.Location + "' ", connection);
            commandCount2InToday.Parameters.Add(Count2InToday);
            commandCount2InOld.Parameters.Add(Count2InOld);
            commandCount4InToday.Parameters.Add(Count4InToday);
            commandCount4InOld.Parameters.Add(Count4InOld);
            commandCountBInToday.Parameters.Add(CountBInToday);
            commandCountBInOld.Parameters.Add(CountBInOld);
            try
            {
                connection.Open();
                commandCard.ExecuteNonQuery();
                commandFine.ExecuteNonQuery();
                commandCash2.ExecuteNonQuery();
                commandCash4.ExecuteNonQuery();
                commandCashb.ExecuteNonQuery();
                commandCount2InToday.ExecuteNonQuery();
                commandCount2InOld.ExecuteNonQuery();
                commandCount4InToday.ExecuteNonQuery();
                commandCount4InOld.ExecuteNonQuery();
                commandCountBInToday.ExecuteNonQuery();
                commandCountBInOld.ExecuteNonQuery();
                connection.Close();
                toolStripStatusLabelStatus.Text = "DONE";

                // check money
                if (Card.Value.ToString().Length > 0)
                {
                    moneyCard = Convert.ToDouble(Card.Value.ToString());
                }
                else
                {
                    moneyCard = 0;
                }
                if (Fine.Value.ToString().Length > 0)
                {
                    moneyFine = Convert.ToDouble(Fine.Value.ToString());
                }
                else
                {
                    moneyFine = 0;
                }
                if (Cash2.Value.ToString().Length > 0)
                {
                    moneyCash2 = Convert.ToDouble(Cash2.Value.ToString());
                }
                else
                {
                    moneyCash2 = 0;
                }
                if (Cash4.Value.ToString().Length > 0)
                {
                    moneyCash4 = Convert.ToDouble(Cash4.Value.ToString());
                }
                else
                {
                    moneyCash4 = 0;
                }
                if (Cashb.Value.ToString().Length > 0)
                {
                    moneyCashb = Convert.ToDouble(Cashb.Value.ToString());
                }
                else
                {
                    moneyCashb = 0;
                }

                // compute sum
                moneyTotal = moneyCard + moneyCash2 + moneyCash4 + moneyCashb + moneyFine;



                // check count

                if (Count2InToday.Value.ToString().Length > 0)
                {
                    count2InToday = Convert.ToInt32(Count2InToday.Value.ToString());
                }
                else
                {
                    count2InToday = 0;
                }
                if (Count2InOld.Value.ToString().Length > 0)
                {
                    count2InOld = Convert.ToInt32(Count2InOld.Value.ToString());
                }
                else
                {
                    count2InOld = 0;
                }
                if (Count4InToday.Value.ToString().Length > 0)
                {
                    count4InToday = Convert.ToInt32(Count4InToday.Value.ToString());
                }
                else
                {
                    count4InToday = 0;
                }
                if (Count4InOld.Value.ToString().Length > 0)
                {
                    count4InOld = Convert.ToInt32(Count4InOld.Value.ToString());
                }
                else
                {
                    count4InOld = 0;
                }

                if (CountBInToday.Value.ToString().Length > 0)
                {
                    countBInToday = Convert.ToInt32(CountBInToday.Value.ToString());
                }
                else
                {
                    countBInToday = 0;
                }
                if (CountBInOld.Value.ToString().Length > 0)
                {
                    countBInOld = Convert.ToInt32(CountBInOld.Value.ToString());
                }
                else
                {
                    countBInOld = 0;
                }

                //COMPUTE
                countTotalIn = count2InToday + count4InToday + countBInToday + count2InOld + count4InOld + countBInOld;
                countTotalOut = count2InOld + count4InOld + countBInOld;

                //Show results
                textBoxTotalR.Text = moneyTotal.ToString();
                textBoxFineR.Text = moneyFine.ToString();
                textBoxCardR.Text = moneyCard.ToString();
                textBoxCashByR.Text = moneyCashb.ToString();
                textBoxCashTwoR.Text = moneyCash2.ToString();
                textBoxCashFourR.Text = moneyCash4.ToString();

                totalCash = moneyCash2 + moneyCash4 + moneyCashb;
                textBoxTotalIn.Text = countTotalIn.ToString();
                textBoxTotalOut.Text = countTotalOut.ToString();
                textBoxTotalP.Text = (countTotalIn - countTotalOut).ToString();
                textBoxTwoIn.Text = (count2InOld + count2InToday).ToString();
                textBoxTwoOut.Text = count2InOld.ToString();
                textBoxTwoP.Text = count2InToday.ToString();

                textBoxFourIn.Text = (count4InOld + count4InToday).ToString();
                textBoxFourOut.Text = count4InOld.ToString();
                textBoxFourP.Text = count4InToday.ToString();

                textBoxByIn.Text = (countBInOld + countBInToday).ToString();
                textBoxByOut.Text = countBInOld.ToString();
                textBoxByP.Text = countBInToday.ToString();
            }
            catch (Exception ex)
            {
                toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
            }
            finally
            {
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {

                }
            }

        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            Flag = false;
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            Flag = false;
        }


    }
}

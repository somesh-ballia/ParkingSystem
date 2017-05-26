using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class Status : Form
    {
        public Status()
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

        private void Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void Status_Load(object sender, EventArgs e)
        {
            // taking date time stamp
            DateTime startDate = DateTime.Today;

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
            commandCard = new SqlCommand( "select @Card = sum(Ammount) from recharge where time > '" + startDate.ToString() + "' and Location = '" + Program.Location + "' ", connection);
            commandFine = new SqlCommand( "select @Fine = sum(Ammount) from fine where time > '" + startDate.ToString() + "' and Location = '" + Program.Location + "' ", connection);
            commandCash2 = new SqlCommand("select @Cash2 = sum(Ammount) from cash where time > '" + startDate.ToString() + "' and Location = '" + Program.Location + "' and VType = '2' ", connection);
            commandCash4 = new SqlCommand("select @Cash4 = sum(Ammount) from cash where time > '" + startDate.ToString() + "' and Location = '" + Program.Location + "' and VType = '4' ", connection);
            commandCashb = new SqlCommand("select @Cashb = sum(Ammount) from cash where time > '" + startDate.ToString() + "' and Location = '" + Program.Location + "' and VType = 'B' ", connection);
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
            int count2InToday, count2InOld, count4InToday, count4InOld,countBInToday, countBInOld, countTotalIn, countTotalOut = 0;

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
            commandCount2InToday = new SqlCommand("select @count2InToday = count(RFID) from today where InTime > '" + startDate.ToString() + "' and VType = '2' and Location = '" + Program.Location + "' ", connection);
            commandCount2InOld = new SqlCommand("select @count2InOld = count(RFID) from old where InTime > '" + startDate.ToString() + "' and VType = '2' and Location = '" + Program.Location + "' ", connection);
            commandCount4InToday = new SqlCommand("select @count4InToday = count(RFID) from today where InTime > '" + startDate.ToString() + "' and VType = '4' and Location = '" + Program.Location + "' ", connection);
            commandCount4InOld = new SqlCommand("select @count4InOld = count(RFID) from old where InTime > '" + startDate.ToString() + "' and VType = '4' and Location = '" + Program.Location + "' ", connection);
            commandCountBInToday = new SqlCommand("select @countBInToday = count(RFID) from today where InTime > '" + startDate.ToString() + "' and VType = 'B' and Location = '" + Program.Location + "' ", connection);
            commandCountBInOld = new SqlCommand("select @countBInOld = count(RFID) from old where InTime > '" + startDate.ToString() + "' and VType = 'B' and Location = '" + Program.Location + "' ", connection);
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
    }
}

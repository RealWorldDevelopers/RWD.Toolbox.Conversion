
using RWD.Toolbox.Conversion.WinForm.Properties;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RWD.Toolbox.Conversion.WinForm
{
    // TODO set Icon
    // TODO Code Analysis  
    // TODO Max Input Values  
    // TODO Call dll not tags
    // TODO Exception handles

    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        //Private OrgHeight As Double = 0
        //Private OrgWidth As Double = 0
        //private int LeftMargin = 25;
        private int TopMargin = 25;

        private int MarginSpace = 10;
        private double MassUnits;

        private double VolUnits;

        private bool OriginalEntry = false;
        public string TextboxFormat = "###,###.###";

        private void _Resize(object sender, EventArgs e)
        {
            try
            {
                //'% increase or decrease in size
                //If OrgHeight = 0 Then OrgHeight = Me.Height
                //If OrgWidth = 0 Then OrgWidth = Me.Width

                //Dim fSize As New SizeF((Me.Width / OrgWidth), (Me.Height / OrgHeight))

                //For Each c As Control In Me.Controls
                //    c.Font = New Font(c.Font.FontFamily, c.Font.Size * fSize.Height)
                //    c.Scale(fSize)
                //Next

                //mass
                lblTitle_Mass.Top = TopMargin;
                lblTitle_Mass.Left = (Width / 2) - (lblTitle_Mass.Width / 2);

                txtMilliGrams.Left = (Width / 2) - (txtMilliGrams.Width / 2);
                txtGrams.Left = txtMilliGrams.Left;
                txtKiloGrams.Left = txtMilliGrams.Left;
                txtMetricTons.Left = txtMilliGrams.Left;
                txtOunces.Left = txtMilliGrams.Left;
                txtPounds.Left = txtMilliGrams.Left;
                txtTons.Left = txtMilliGrams.Left;

                txtMilliGrams.Top = lblTitle_Mass.Bottom + MarginSpace;
                txtGrams.Top = txtMilliGrams.Bottom + MarginSpace;
                txtKiloGrams.Top = txtGrams.Bottom + MarginSpace;
                txtMetricTons.Top = txtKiloGrams.Bottom + MarginSpace;
                txtOunces.Top = txtMetricTons.Bottom + MarginSpace;
                txtPounds.Top = txtOunces.Bottom + MarginSpace;
                txtTons.Top = txtPounds.Bottom + MarginSpace;

                lblMilliGrams.Top = txtMilliGrams.Top;
                lblGrams.Top = txtGrams.Top;
                lblKiloGrams.Top = txtKiloGrams.Top;
                lblMetricTons.Top = txtMetricTons.Top;
                lblOunces.Top = txtOunces.Top;
                lblPounds.Top = txtPounds.Top;
                lblTons.Top = txtTons.Top;

                lblMilliGrams.Left = txtMilliGrams.Left - (lblMilliGrams.Width + MarginSpace);
                lblGrams.Left = txtGrams.Left - (lblGrams.Width + MarginSpace);
                lblKiloGrams.Left = txtKiloGrams.Left - (lblKiloGrams.Width + MarginSpace);
                lblMetricTons.Left = txtMetricTons.Left - (lblMetricTons.Width + MarginSpace);
                lblOunces.Left = txtOunces.Left - (lblOunces.Width + MarginSpace);
                lblPounds.Left = txtPounds.Left - (lblPounds.Width + MarginSpace);
                lblTons.Left = txtTons.Left - (lblTons.Width + MarginSpace);

                lblMg.Top = txtMilliGrams.Top;
                lblg.Top = txtGrams.Top;
                lblKg.Top = txtKiloGrams.Top;
                lblt.Top = txtMetricTons.Top;
                lbloz.Top = txtOunces.Top;
                lbllbs.Top = txtPounds.Top;
                lblton.Top = txtTons.Top;

                lblMg.Left = txtMilliGrams.Right + MarginSpace;
                lblg.Left = txtGrams.Right + MarginSpace;
                lblKg.Left = txtKiloGrams.Right + MarginSpace;
                lblt.Left = txtMetricTons.Right + MarginSpace;
                lbloz.Left = txtOunces.Right + MarginSpace;
                lbllbs.Left = txtPounds.Right + MarginSpace;
                lblton.Left = txtTons.Right + MarginSpace;

                //volume
                lblTitle_Vol.Top = TopMargin;
                lblTitle_Vol.Left = (Width / 2) - (lblTitle_Vol.Width / 2);

                txtMilliLiters.Left = (Width / 2) - (txtMilliLiters.Width / 2);
                txtLiters.Left = txtMilliLiters.Left;
                txtGallons.Left = txtMilliLiters.Left;
                txtFluidOunces.Left = txtMilliLiters.Left;
                txtCups.Left = txtMilliLiters.Left;
                txtPints.Left = txtMilliLiters.Left;
                txtQuarts.Left = txtMilliLiters.Left;
                txtTableSpoons.Left = txtMilliLiters.Left;
                txtTeaspoons.Left = txtMilliLiters.Left;

                txtMilliLiters.Top = lblTitle_Vol.Bottom + MarginSpace;
                txtLiters.Top = txtMilliLiters.Bottom + MarginSpace;
                txtGallons.Top = txtLiters.Bottom + MarginSpace;
                txtFluidOunces.Top = txtGallons.Bottom + MarginSpace;
                txtCups.Top = txtFluidOunces.Bottom + MarginSpace;
                txtPints.Top = txtCups.Bottom + MarginSpace;
                txtQuarts.Top = txtPints.Bottom + MarginSpace;
                txtTableSpoons.Top = txtQuarts.Bottom + MarginSpace;
                txtTeaspoons.Top = txtTableSpoons.Bottom + MarginSpace;

                lblMilliLiters.Top = txtMilliLiters.Top;
                lblLiters.Top = txtLiters.Top;
                lblGallons.Top = txtGallons.Top;
                lblFluidOunces.Top = txtFluidOunces.Top;
                lblCups.Top = txtCups.Top;
                lblpints.Top = txtPints.Top;
                lblQuarts.Top = txtQuarts.Top;
                lblTableSpoons.Top = txtTableSpoons.Top;
                lblTeaspoons.Top = txtTeaspoons.Top;

                lblMilliLiters.Left = txtMilliLiters.Left - (lblMilliLiters.Width + MarginSpace);
                lblLiters.Left = txtLiters.Left - (lblLiters.Width + MarginSpace);
                lblGallons.Left = txtGallons.Left - (lblGallons.Width + MarginSpace);
                lblFluidOunces.Left = txtFluidOunces.Left - (lblFluidOunces.Width + MarginSpace);
                lblCups.Left = txtCups.Left - (lblCups.Width + MarginSpace);
                lblpints.Left = txtPints.Left - (lblpints.Width + MarginSpace);
                lblQuarts.Left = txtQuarts.Left - (lblQuarts.Width + MarginSpace);
                lblTableSpoons.Left = txtTableSpoons.Left - (lblTableSpoons.Width + MarginSpace);
                lblTeaspoons.Left = txtTeaspoons.Left - (lblTeaspoons.Width + MarginSpace);

                lblmL.Top = txtMilliLiters.Top;
                lblL.Top = txtLiters.Top;
                lblGal.Top = txtGallons.Top;
                lblfloz.Top = txtFluidOunces.Top;
                lblcup.Top = txtCups.Top;
                lblpint.Top = txtPints.Top;
                lblqt.Top = txtQuarts.Top;
                lbltbl.Top = txtTableSpoons.Top;
                lbltsp.Top = txtTeaspoons.Top;

                lblmL.Left = txtMilliLiters.Right + MarginSpace;
                lblL.Left = txtLiters.Right + MarginSpace;
                lblGal.Left = txtGallons.Right + MarginSpace;
                lblfloz.Left = txtFluidOunces.Right + MarginSpace;
                lblcup.Left = txtCups.Right + MarginSpace;
                lblpint.Left = txtPints.Right + MarginSpace;
                lblqt.Left = txtQuarts.Right + MarginSpace;
                lbltbl.Left = txtTableSpoons.Right + MarginSpace;
                lbltsp.Left = txtTeaspoons.Right + MarginSpace;

                //Temp
                lblTitle_Temp.Top = TopMargin;
                lblTitle_Temp.Left = (Width / 2) - (lblTitle_Temp.Width / 2);

                txtCelcius.Left = (Width / 2) - (txtCelcius.Width / 2);
                txtFahrenheit.Left = txtCelcius.Left;

                txtCelcius.Top = lblTitle_Temp.Bottom + MarginSpace;
                txtFahrenheit.Top = txtCelcius.Bottom + MarginSpace;

                lblCelcius.Top = txtCelcius.Top;
                lblFahrenheit.Top = txtFahrenheit.Top;

                lblCelcius.Left = txtCelcius.Left - (lblCelcius.Width + MarginSpace);
                lblFahrenheit.Left = txtFahrenheit.Left - (lblFahrenheit.Width + MarginSpace);

                lblC.Top = txtCelcius.Top;
                lblF.Top = txtFahrenheit.Top;

                lblC.Left = txtCelcius.Right + MarginSpace;
                lblF.Left = txtFahrenheit.Right + MarginSpace;

                //OrgHeight = Me.Height
                //OrgWidth = Me.Width

                //force repaint and draw
                Refresh();

            }
            catch (Exception ex)
            {
                //  // TODO ExceptionCaught?.Invoke(ex);
            }
        }

        private void _Load(object sender, EventArgs e)
        {
            // Set window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }

            // Set window size
            if (Settings.Default.WindowSize != null)
            {
                this.Size = Settings.Default.WindowSize;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // only 1-9
                if (!Regex.IsMatch(e.KeyChar.ToString(), @"[0-9.]") && !(e.KeyChar == '\b'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                //   // TODO ExceptionCaught?.Invoke(ex);
                e.Handled = true;
            }
        }

        private void txt_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                TextBox txBox = sender as TextBox;
                txBox.SelectAll();
            }
            catch (Exception ex)
            {
                //  // TODO ExceptionCaught?.Invoke(ex);
            }
        }

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            // Copy window location to app settings
            Settings.Default.WindowLocation = Location;

            // Copy window size to app settings
            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.WindowSize = Size;
            }
            else
            {
                Settings.Default.WindowSize = RestoreBounds.Size;
            }

            // Save settings
            Settings.Default.Save();
        }

        
        #region "Mass Conversions"

        private void English_Mass_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                TextBox txBox = sender as TextBox;
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        MassUnits = 0;
                        FillEnglishToMetric_Mass("ALL");
                    }
                    else
                    {
                        OriginalEntry = true;
                        switch (txBox.Name)
                        {
                            case "txtOunces":
                                MassUnits = Math.Abs(Convert.ToDouble(txBox.Text)) / Convert.ToDouble(txBox.Tag);
                                break;
                            default:
                                MassUnits = Math.Abs(Convert.ToDouble(txBox.Text)) * Convert.ToDouble(txBox.Tag);
                                break;
                        }
                        FillEnglishToMetric_Mass(txBox.Name);
                        double dValue;
                        if (double.TryParse(txBox.Text, out dValue))
                        {
                            txBox.Text = dValue.ToString(TextboxFormat);
                            txBox.SelectionStart = txBox.Text.Length;
                            txBox.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                MassUnits = 0;
                FillEnglishToMetric_Mass("ALL");
            }

        }

        private void Metric_Mass_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                TextBox txBox = sender as TextBox;
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        MassUnits = 0;
                        FillMetricToEnglish_Mass("ALL");
                    }
                    else
                    {
                        OriginalEntry = true;
                        switch (txBox.Name)
                        {
                            case "txtMetricTons":
                                MassUnits = Math.Abs(Convert.ToDouble(txBox.Text)) * Convert.ToDouble(txBox.Tag);
                                break;
                            default:
                                MassUnits = Math.Abs(Convert.ToDouble(txBox.Text)) / Convert.ToDouble(txBox.Tag);
                                break;
                        }
                        FillMetricToEnglish_Mass(txBox.Name);
                        double dValue;
                        if (double.TryParse(txBox.Text, out dValue))
                        {
                            txBox.Text = dValue.ToString(TextboxFormat);
                            txBox.SelectionStart = txBox.Text.Length;
                            txBox.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                MassUnits = 0;
                FillMetricToEnglish_Mass("ALL");
            }
        }

        /// <summary>
        /// Recalculate Metric Mass Values
        /// </summary>
        private void FillMetricToEnglish_Mass(string SenderName)
        {
            try
            {
                if (!(SenderName == "txtGrams"))
                    txtGrams.Text = (MassUnits * 1000).ToString(TextboxFormat);
                if (!(SenderName == "txtMilliGrams"))
                    txtMilliGrams.Text = (MassUnits * 1000000).ToString(TextboxFormat);
                if (!(SenderName == "txtKiloGrams"))
                    txtKiloGrams.Text = (MassUnits).ToString(TextboxFormat);
                if (!(SenderName == "txtMetricTons"))
                    txtMetricTons.Text = (MassUnits / 1000).ToString(TextboxFormat);

                if (!(SenderName == "txtOunces"))
                    txtOunces.Text = (MassUnits * 35.274).ToString(TextboxFormat);
                if (!(SenderName == "txtPounds"))
                    txtPounds.Text = (MassUnits * 2.20462).ToString(TextboxFormat);
                if (!(SenderName == "txtTons"))
                    txtTons.Text = (MassUnits / 1016).ToString(TextboxFormat);

            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                MassUnits = 0;
                FillEnglishToMetric_Mass("ALL");
            }
            finally
            {
                OriginalEntry = false;
            }

        }

        /// <summary>
        /// Recalculate US Mass Values
        /// </summary>
        private void FillEnglishToMetric_Mass(string SenderName)
        {
            try
            {
                if (!(SenderName == "txtGrams"))
                    txtGrams.Text = (MassUnits * 453.592).ToString(TextboxFormat);
                if (!(SenderName == "txtMilliGrams"))
                    txtMilliGrams.Text = (MassUnits * 453592).ToString(TextboxFormat);
                if (!(SenderName == "txtKiloGrams"))
                    txtKiloGrams.Text = (MassUnits * 0.453592).ToString(TextboxFormat);
                if (!(SenderName == "txtMetricTons"))
                    txtMetricTons.Text = (Convert.ToDouble(txtKiloGrams.Text) / 1000).ToString(TextboxFormat);

                if (!(SenderName == "txtOunces"))
                    txtOunces.Text = (MassUnits * 16).ToString(TextboxFormat);
                if (!(SenderName == "txtPounds"))
                    txtPounds.Text = (MassUnits).ToString(TextboxFormat);
                if (!(SenderName == "txtTons"))
                    txtTons.Text = (MassUnits / 2239.9).ToString(TextboxFormat);

            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                MassUnits = 0;
                FillMetricToEnglish_Mass("ALL");
            }
            finally
            {
                OriginalEntry = false;
            }
        }

        #endregion
        

        #region "Volume Conversions"

        private void English_Vol_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                TextBox txBox = sender as TextBox;
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        VolUnits = 0;
                        FillEnglishToMetric_Vol("ALL");
                    }
                    else
                    {
                        OriginalEntry = true;
                        VolUnits = Math.Abs(Convert.ToDouble(txBox.Text)) / Convert.ToDouble(txBox.Tag);
                        FillEnglishToMetric_Vol(txBox.Name);
                        double dValue;
                        if (double.TryParse(txBox.Text, out dValue))
                        {
                            txBox.Text = dValue.ToString(TextboxFormat);
                            txBox.SelectionStart = txBox.Text.Length;
                            txBox.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                VolUnits = 0;
                FillEnglishToMetric_Vol("ALL");
            }

        }

        private void Metric_Vol_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox txBox = sender as TextBox;
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        VolUnits = 0;
                        FillMetricToEnglish_Vol("ALL");
                    }
                    else
                    {
                        OriginalEntry = true;
                        VolUnits = Math.Abs(Convert.ToDouble(txBox.Text)) * Convert.ToDouble(txBox.Tag);
                        FillMetricToEnglish_Vol(txBox.Name);
                        double dValue;
                        if (double.TryParse(txBox.Text, out dValue))
                        {
                            txBox.Text = dValue.ToString(TextboxFormat);
                            txBox.SelectionStart = txBox.Text.Length;
                            txBox.SelectionLength = 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                VolUnits = 0;
                FillMetricToEnglish_Vol("ALL");
            }
        }

        /// <summary>
        /// Recalculate Metric Volume Values
        /// </summary>
        private void FillMetricToEnglish_Vol(string SenderName)
        {
            try
            {
                if (!(SenderName == "txtMilliLiters"))
                    txtMilliLiters.Text = (VolUnits * 1000).ToString(TextboxFormat);
                if (!(SenderName == "txtLiters"))
                    txtLiters.Text = (VolUnits).ToString(TextboxFormat);

                if (!(SenderName == "txtFluidOunces"))
                    txtFluidOunces.Text = (VolUnits * 33.814).ToString(TextboxFormat);
                if (!(SenderName == "txtGallons"))
                    txtGallons.Text = (VolUnits / 3.78514).ToString(TextboxFormat);
                if (!(SenderName == "txtPints"))
                    txtPints.Text = (VolUnits * 2.1134).ToString(TextboxFormat);
                if (!(SenderName == "txtCups"))
                    txtCups.Text = (VolUnits * 4.2268).ToString(TextboxFormat);
                if (!(SenderName == "txtQuarts"))
                    txtQuarts.Text = (VolUnits * 1.0567).ToString(TextboxFormat);

                if (!(SenderName == "txtTableSpoons"))
                    txtTableSpoons.Text = (VolUnits * 67.628).ToString(TextboxFormat);
                if (!(SenderName == "txtTeaspoons"))
                    txtTeaspoons.Text = (VolUnits * 202.884).ToString(TextboxFormat);

            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                VolUnits = 0;
                FillEnglishToMetric_Vol("ALL");
            }
            finally
            {
                OriginalEntry = false;
            }

        }

        /// <summary>
        /// Recalculate US Volume Values
        /// </summary>
        private void FillEnglishToMetric_Vol(string SenderName)
        {
            try
            {
                if (!(SenderName == "txtMilliLiters"))
                    txtMilliLiters.Text = (VolUnits * 3785.14).ToString(TextboxFormat);
                if (!(SenderName == "txtLiters"))
                    txtLiters.Text = (VolUnits * 3.78514).ToString(TextboxFormat);

                if (!(SenderName == "txtFluidOunces"))
                    txtFluidOunces.Text = (VolUnits * 128).ToString(TextboxFormat);
                if (!(SenderName == "txtGallons"))
                    txtGallons.Text = (VolUnits).ToString(TextboxFormat);
                if (!(SenderName == "txtPints"))
                    txtPints.Text = (VolUnits * 8).ToString(TextboxFormat);
                if (!(SenderName == "txtCups"))
                    txtCups.Text = (VolUnits * 16).ToString(TextboxFormat);
                if (!(SenderName == "txtQuarts"))
                    txtQuarts.Text = (VolUnits * 4).ToString(TextboxFormat);

                if (!(SenderName == "txtTableSpoons"))
                    txtTableSpoons.Text = (VolUnits * 256).ToString(TextboxFormat);
                if (!(SenderName == "txtTeaspoons"))
                    txtTeaspoons.Text = (VolUnits * 768).ToString(TextboxFormat);

            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                VolUnits = 0;
                FillMetricToEnglish_Vol("ALL");
            }
            finally
            {
                OriginalEntry = false;
            }
        }

        #endregion

        
        #region "Temperature Conversion"

        private void Temp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox txBox = sender as TextBox;
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        txtFahrenheit.Text = "";
                        txtCelcius.Text = "";
                    }
                    else
                    {
                        if (txBox.Name == "txtFahrenheit")
                        {
                            OriginalEntry = true;
                            txtCelcius.Text = Measurement.ConvertFahrenheitToCelcius(Convert.ToDouble(txtFahrenheit.Text)).ToString();
                        }
                        else
                        {
                            OriginalEntry = true;
                            txtFahrenheit.Text = Measurement.ConvertCelciusToFahrenheit(Convert.ToDouble(txtCelcius.Text)).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO ExceptionCaught?.Invoke(ex);
                txtFahrenheit.Text = "";
                txtCelcius.Text = "";
            }
            finally
            {
                OriginalEntry = false;
            }
        }

        #endregion

        
    }
}

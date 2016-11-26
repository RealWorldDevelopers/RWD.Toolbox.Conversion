
using NLog;
using RWD.Toolbox.Conversion.WinForm.ExceptionHelper;
using RWD.Toolbox.Conversion.WinForm.Properties;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RWD.Toolbox.Conversion.WinForm
{
    // TODO Create Installer

    // TODO Commit to Github

    public partial class Display : Form
    {

        private IExceptionHelper _exceptionHelper;

        //Private OrgHeight As Double = 0
        //Private OrgWidth As Double = 0
        //private int LeftMargin = 25;
        private int TopMargin = 25;

        private int MarginSpace = 10;
        private double MassUnits;

        private double VolUnits;

        private bool OriginalEntry = false;
        private const string TextboxFormat = "###,###.###";
        private string EntryFormat = "###,###.#";
        private const string RegEx_Decimal = @"^[+-]?((\d+(\.\d+)?)|(\.\d+))$";

        public Display()
        {
            InitializeComponent();
            ExceptionHelperFactory factory = new ExceptionHelperFactory();
            _exceptionHelper = factory.CreateNewExceptionHelper();
        }

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
                _exceptionHelper.LogException(ex, LogLevel.Error);
            }
        }              

        private void _Load(object sender, EventArgs e)
        {                       
            // Set window location
            if (Settings.Default.WindowLocation != null)
            {
                Location = Settings.Default.WindowLocation;
            }

            // Set window size
            if (Settings.Default.WindowSize != null)
            {
                Size = Settings.Default.WindowSize;
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

        private void English_Mass_TextChanged(object sender, EventArgs e)
        {
            TextBox txBox = sender as TextBox;
            try
            {                
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        MassUnits = 0;
                        FillEnglishToMetric_Mass("ALL");
                    }
                    else
                    {
                        var rawNum = txBox.Text.Replace(",", "");

                        switch (txBox.Name)
                        {
                            case "txtOunces":
                                MassUnits = Math.Abs(Convert.ToDouble(rawNum)) / Convert.ToDouble(txBox.Tag);
                                break;
                            default:
                                MassUnits = Math.Abs(Convert.ToDouble(rawNum)) * Convert.ToDouble(txBox.Tag);
                                break;
                        }


                        if (Regex.IsMatch(rawNum, RegEx_Decimal))
                        {
                            OriginalEntry = true;
                            FillEnglishToMetric_Mass(txBox.Name);
                            FormatEntryTextbox(txBox);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Data.Add("txBox.Name", txBox.Name);
                ex.Data.Add("txBox.Text", txBox.Text);
                _exceptionHelper.LogException(ex, LogLevel.Error);
                OriginalEntry = false;
                FillEnglishToMetric_Mass("ALL");
            }

        }

        private void Metric_Mass_TextChanged(object sender, EventArgs e)
        {
            TextBox txBox = sender as TextBox;
            try
            {                
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        MassUnits = 0;
                        FillMetricToEnglish_Mass("ALL");
                    }
                    else
                    {
                        var rawNum = txBox.Text.Replace(",", "");

                        switch (txBox.Name)
                        {
                            case "txtMetricTons":
                                MassUnits = Math.Abs(Convert.ToDouble(rawNum)) * Convert.ToDouble(txBox.Tag);
                                break;
                            default:
                                MassUnits = Math.Abs(Convert.ToDouble(rawNum)) / Convert.ToDouble(txBox.Tag);
                                break;
                        }
                        if (Regex.IsMatch(rawNum, RegEx_Decimal))
                        {
                            OriginalEntry = true;
                            FillMetricToEnglish_Mass(txBox.Name);
                            FormatEntryTextbox(txBox);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Data.Add("txBox.Name", txBox.Name);
                ex.Data.Add("txBox.Text", txBox.Text);
                _exceptionHelper.LogException(ex, LogLevel.Error);
                OriginalEntry = false;
                FillMetricToEnglish_Mass("ALL");
            }
        }

        /// <summary>
        /// Recalculate Metric Mass Values
        /// </summary>
        /// <remarks>If originating textbox is Metric Measurment then VolUnits is in KiloGrams.</remarks>
        private void FillMetricToEnglish_Mass(string SenderName)
        {
            try
            {
                // MassUnits = KiloGrams

                if (!(SenderName == "txtGrams"))
                    txtGrams.Text = Measurement.KiloGramsToGrams(MassUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtMilliGrams"))
                    txtMilliGrams.Text = Measurement.KiloGramsToMilliGrams(MassUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtKiloGrams"))
                    txtKiloGrams.Text = (MassUnits).ToString(TextboxFormat);
                if (!(SenderName == "txtMetricTons"))
                    txtMetricTons.Text = Measurement.KilogramsToMetricTons(MassUnits).Value.ToString(TextboxFormat);

                if (!(SenderName == "txtOunces"))
                    txtOunces.Text = Measurement.GramsToOunces(Measurement.KiloGramsToGrams(MassUnits)).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtPounds"))
                    txtPounds.Text = Measurement.KiloGramsToPounds(MassUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtTons"))
                    txtTons.Text = Measurement.PoundsToTons(Measurement.KiloGramsToPounds(MassUnits).Value).Value.ToString(TextboxFormat);

            }
            catch (Exception ex)
            {
                ex.Data.Add("SenderName", SenderName);
                ex.Data.Add("MassUnits", MassUnits);
                _exceptionHelper.LogException(ex, LogLevel.Error);
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
        /// <remarks>If originating textbox is US Measurment then VolUnits is in Pounds.</remarks>
        private void FillEnglishToMetric_Mass(string SenderName)
        {
            try
            {
                // MassUnits = pounds

                if (!(SenderName == "txtGrams"))
                    txtGrams.Text = Measurement.KiloGramsToGrams(Measurement.PoundsToKiloGrams(MassUnits)).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtMilliGrams"))
                    txtMilliGrams.Text = Measurement.KiloGramsToMilliGrams(Measurement.PoundsToKiloGrams(MassUnits)).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtKiloGrams"))
                    txtKiloGrams.Text = Measurement.PoundsToKiloGrams(MassUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtMetricTons"))
                    txtMetricTons.Text = Measurement.KilogramsToMetricTons(Measurement.PoundsToKiloGrams(MassUnits)).Value.ToString(TextboxFormat);

                if (!(SenderName == "txtOunces"))
                    txtOunces.Text = Measurement.PoundsToOunces(MassUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtPounds"))
                    txtPounds.Text = (MassUnits).ToString(TextboxFormat);
                if (!(SenderName == "txtTons"))
                    txtTons.Text = Measurement.PoundsToTons(MassUnits).Value.ToString(TextboxFormat);

            }
            catch (Exception ex)
            {
                ex.Data.Add("SenderName", SenderName);
                ex.Data.Add("MassUnits", MassUnits);
                _exceptionHelper.LogException(ex, LogLevel.Error);
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

        private void English_Vol_TextChanged(object sender, EventArgs e)
        {
            TextBox txBox = sender as TextBox;
            try
            {               
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        VolUnits = 0;
                        FillEnglishToMetric_Vol("ALL");
                    }
                    else
                    {
                        var rawNum = txBox.Text.Replace(",", "");

                        VolUnits = Math.Abs(Convert.ToDouble(rawNum)) / Convert.ToDouble(txBox.Tag);

                        if (Regex.IsMatch(rawNum, RegEx_Decimal))
                        {
                            OriginalEntry = true;
                            FillEnglishToMetric_Vol(txBox.Name);
                            FormatEntryTextbox(txBox);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ex.Data.Add("txBox.Name", txBox.Name);
                ex.Data.Add("txBox.Text", txBox.Text);
                _exceptionHelper.LogException(ex, LogLevel.Error);
                OriginalEntry = false;
                FillEnglishToMetric_Vol("ALL");
            }

        }

        private void Metric_Vol_TextChanged(object sender, EventArgs e)
        {
            TextBox txBox = sender as TextBox;

            try
            {                
                if (!OriginalEntry)
                {
                    if (string.IsNullOrEmpty(txBox.Text))
                    {
                        VolUnits = 0;
                        FillMetricToEnglish_Vol("ALL");
                    }
                    else
                    {
                        var rawNum = txBox.Text.Replace(",", "");

                        VolUnits = Math.Abs(Convert.ToDouble(rawNum)) * Convert.ToDouble(txBox.Tag);

                        if (Regex.IsMatch(rawNum, RegEx_Decimal))
                        {
                            OriginalEntry = true;
                            FillMetricToEnglish_Vol(txBox.Name);
                            FormatEntryTextbox(txBox);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Data.Add("txBox.Name", txBox.Name);
                ex.Data.Add("txBox.Text", txBox.Text);
                _exceptionHelper.LogException(ex, LogLevel.Error);
                OriginalEntry = false;
                FillMetricToEnglish_Vol("ALL");
            }
        }

        /// <summary>
        /// Recalculate Metric Volume Values
        /// </summary>
        /// <remarks>If originating textbox is Metric Measurment then VolUnits is in Liters.</remarks>
        private void FillMetricToEnglish_Vol(string SenderName)
        {
            try
            {
                // VolUnits = liters

                if (!(SenderName == "txtMilliLiters"))
                    txtMilliLiters.Text = Measurement.LitersToMilliLiters(VolUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtLiters"))
                    txtLiters.Text = (VolUnits).ToString(TextboxFormat);

                if (!(SenderName == "txtFluidOunces"))
                    txtFluidOunces.Text = Measurement.LitersToOunces(VolUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtGallons"))
                    txtGallons.Text = Measurement.LitersToGallons(VolUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtPints"))
                    txtPints.Text = Measurement.QuartsToPints(Measurement.LitersToQuarts(VolUnits)).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtCups"))
                    txtCups.Text = Measurement.QuartsToCups(Measurement.LitersToQuarts(VolUnits)).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtQuarts"))
                    txtQuarts.Text = Measurement.LitersToQuarts(VolUnits).Value.ToString(TextboxFormat);

                if (!(SenderName == "txtTableSpoons"))
                    txtTableSpoons.Text = Measurement.MilliLitersToTablespoons(Measurement.LitersToMilliLiters(VolUnits)).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtTeaspoons"))
                    txtTeaspoons.Text = Measurement.MilliLitersToTeaspoons(Measurement.LitersToMilliLiters(VolUnits)).Value.ToString(TextboxFormat);

            }
            catch (Exception ex)
            {
                ex.Data.Add("SenderName", SenderName);
                ex.Data.Add("VolUnits", VolUnits);
                _exceptionHelper.LogException(ex, LogLevel.Error);
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
        /// <remarks>If originating textbox is US Measurment then VolUnits is in Gallons.</remarks>
        private void FillEnglishToMetric_Vol(string SenderName)
        {
            try
            {
                // VolUnits = gallons

                if (!(SenderName == "txtMilliLiters"))
                    txtMilliLiters.Text = Measurement.LitersToMilliLiters(Measurement.GallonsToLiters(VolUnits)).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtLiters"))
                    txtLiters.Text = Measurement.GallonsToLiters(VolUnits).Value.ToString(TextboxFormat);

                if (!(SenderName == "txtFluidOunces"))
                    txtFluidOunces.Text = Measurement.GallonsToOunces(VolUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtGallons"))
                    txtGallons.Text = (VolUnits).ToString(TextboxFormat);
                if (!(SenderName == "txtPints"))
                    txtPints.Text = Measurement.GallonsToPints(VolUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtCups"))
                    txtCups.Text = Measurement.GallonsToCups(VolUnits).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtQuarts"))
                    txtQuarts.Text = Measurement.GallonsToQuarts(VolUnits).Value.ToString(TextboxFormat);

                if (!(SenderName == "txtTableSpoons"))
                    txtTableSpoons.Text = Measurement.OuncesToTablespoons(Measurement.GallonsToOunces(VolUnits)).Value.ToString(TextboxFormat);
                if (!(SenderName == "txtTeaspoons"))
                    txtTeaspoons.Text = Measurement.OuncesToTeaspoons(Measurement.GallonsToOunces(VolUnits)).Value.ToString(TextboxFormat);

            }
            catch (Exception ex)
            {
                ex.Data.Add("SenderName", SenderName);
                ex.Data.Add("VolUnits", VolUnits);
                _exceptionHelper.LogException(ex, LogLevel.Error);
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
            TextBox txBox = sender as TextBox;

            try
            {                
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
                ex.Data.Add("txBox.Name", txBox.Name);
                ex.Data.Add("txBox.Text", txBox.Text);
                _exceptionHelper.LogException(ex, LogLevel.Error);
                txtFahrenheit.Text = "";
                txtCelcius.Text = "";
            }
            finally
            {
                OriginalEntry = false;
            }
        }

        #endregion

        private void FormatEntryTextbox(TextBox txBox)
        {
            var rawNum = txBox.Text.Replace(",", "");

            double dValue;
            if (double.TryParse(rawNum, out dValue))
            {
                var idx = rawNum.IndexOf('.');
                if (idx >= 0)
                {
                    var p = rawNum.Length - idx - 1;
                    var std = EntryFormat.Length - EntryFormat.IndexOf('.') - 1;
                    if (p > std)
                    {
                        EntryFormat = EntryFormat.PadRight(EntryFormat.Length + 1, '#');
                    }
                }

                txBox.Text = dValue.ToString(EntryFormat);
                txBox.SelectionStart = txBox.Text.Length;
                txBox.SelectionLength = 0;
            }
        }

    }
}

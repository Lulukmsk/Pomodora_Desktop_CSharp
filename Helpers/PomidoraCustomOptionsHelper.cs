using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PomidoraWins.Helpers
{
    public static class PomidoraCustomOptionsHelper
    {
        public const string Zero = "0";
        public static Regex PomidoraHourSettingsRestictionRegex = new Regex(@"^(2[0-4]|1?[0-9]?)$");
        public static Regex PomidoraMinutesAndSecondsSettingsRestictionRegex = new Regex(@"^[1-5]?[0-9]?$");

        public static void PomidoraHandleResctiction(TextCompositionEventArgs eventArgs, Regex restiction)
        {
            var source = eventArgs.Source as TextBox;
            if (source != null)
            {
                var result = GetTexBoxResultText(source, eventArgs.Text);
                if (!restiction.IsMatch(result))
                {
                    eventArgs.Handled = true;
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(result);
                        HandleCornerCases(source, eventArgs, result);
                    }
                    catch
                    {
                        eventArgs.Handled = true;
                    }
                }
            }
        }

        private static string GetTexBoxResultText(TextBox source, string input)
        {
            StringBuilder res = new StringBuilder();
            if (source.Text == Zero)
            {
                //If initial text is Zero, it will be the same as just input
                res.Append(input);
            }
            else
            {
                //Add initial text
                res.Append(source.Text);
                //Delete selected text
                res.Remove(res.ToString().IndexOf(source.SelectedText), source.SelectedText.Length);
                //Add input text
                res.Append(input);
            }

            return res.ToString();
        }

        private static void HandleCornerCases(TextBox source, TextCompositionEventArgs eventArgs, string result)
        {
            if (source.Text == Zero)
            {
                //If initial text is Zero, lets just replace it
                source.Text = "";
            }
        }
    }
}

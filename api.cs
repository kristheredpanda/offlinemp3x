using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class api
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null; // Or throw an exception, depending on your error handling strategy
            }

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                try
                {
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
                catch (ArgumentException ex)
                {
                    // Handle cases where the byte array does not represent a valid image format
                    Console.WriteLine($"Error converting byte array to image: {ex.Message}");
                    return null;
                }
            }
        }

        public static void CenterPictureBox(PictureBox picBox, int y)
        {
            // Calculate the new X coordinate
            int x = (picBox.Parent.ClientSize.Width - picBox.Width) / 2;

            // Set the location
            picBox.Location = new Point(x, y);
        }

        public static void CenterButton(Button button, int y)
        {
            // Calculate the new X coordinate
            int x = (button.Parent.ClientSize.Width - button.Width) / 2;

            // Set the location
            button.Location = new Point(x, y);
        }

        public static void CenterPanel(Panel panel, int y)
        {
            // Calculate the new X coordinate
            int x = (panel.Parent.ClientSize.Width - panel.Width) / 2;

            // Set the location
            panel.Location = new Point(x, y);
        }

        public static void CenterLabel(Label label, int y)
        {
            // Calculate the new X coordinate
            int x = (label.Parent.ClientSize.Width - label.Width) / 2;

            // Set the location
            label.Location = new Point(x, y);
        }
    }
}

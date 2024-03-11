namespace ImageProcessing
{
    static class Rotation
    {
        public static Bitmap RotateImage(Bitmap original, float angle)
        {
            Bitmap rotated = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(rotated))
            {
                // Set the rotation point to the center of the image
                g.TranslateTransform(original.Width / 2, original.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-original.Width / 2, -original.Height / 2);

                // Draw the image onto the rotated graphics
                g.DrawImage(original, new Point(0, 0));
            }

            return rotated;
        }
    }
}

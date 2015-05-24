/*Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. You are not allowed to use the File class or similar helper classes.*/

namespace _04.CopyBinaryFile
    {
    using System.Diagnostics;
    using System.IO;

    class CopyBinaryFile
        {
        const string Image = "../../picture.jpg";
        const string CopiedImage = "../../copy.jpg";

        static void Main()
            {
            using (var source = new FileStream(Image, FileMode.Open))
                {
                using (var destination = new FileStream(CopiedImage, FileMode.Create))
                    {
                    byte[] buffer = new byte[source.Length];
                    while (true)
                        {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                            {
                            break;
                            }

                        destination.Write(buffer, 0, readBytes);
                        }
                    }
                }

            // open image file with results, this file has been just created
            Process.Start(@"..\..\copy.jpg");
            }
        }
    }

using Avatara;
using Avatara.Figure;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace AvataraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FigureExtractor.Parse();

                var Parts = FigureExtractor.Parts;

                var figuredataReader = new FiguredataReader();
                figuredataReader.LoadFigurePalettes();
                figuredataReader.loadFigureSetTypes();
                figuredataReader.LoadFigureSets();

                //string figure = "hd-180-1.hr-100-.ch-260-62.lg-275-64.ha-1008-.ea-1402-.ca-1806-73";
                string figure = "8004718501285022900280543";
                if (Regex.IsMatch(figure, @"^\d+$"))
                {
                    figuredataReader.LoadOldFigureData();
                }
                Console.WriteLine("Parsing: " + figure);
                var action = "wlk";
                var gesture = "sml";
                var item = 6;

                var avata = new Avatar(figure, false, 0, 0, figuredataReader, action, gesture, false, 1, item);
                File.WriteAllBytes("figure0-0.png", avata.Run());

                var avatar0 = new Avatar(figure, false, 1, 1, figuredataReader, action, gesture, false, 1, item);
                File.WriteAllBytes("figure1-1.png", avatar0.Run());

                var avatar = new Avatar(figure, false, 2, 2, figuredataReader, action, gesture, false, 1, item);
                File.WriteAllBytes("figure2-2.png", avatar.Run());

                var avatar1 = new Avatar(figure, false, 3, 3, figuredataReader, action, gesture, false, 1, item);
                File.WriteAllBytes("figure3-3.png", avatar1.Run());

                var avatar2 = new Avatar(figure, false, 4, 4, figuredataReader, action, gesture, false, 1, item);
                File.WriteAllBytes("figure4-4.png", avatar2.Run());

                var avatar3 = new Avatar(figure, false, 5, 5, figuredataReader, action, gesture, false, 1, item);
                File.WriteAllBytes("figure5-5.png", avatar3.Run());

                var avatar4 = new Avatar(figure, false, 6, 6, figuredataReader, action, gesture, false, 1, item);
                File.WriteAllBytes("figure6-6.png", avatar4.Run());

                var avatar5 = new Avatar(figure, false, 7, 7, figuredataReader, action, gesture, false, 1, item);
                File.WriteAllBytes("figure7-7.png", avatar5.Run());

                Console.WriteLine("Done");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.Read();
        }
    }
}

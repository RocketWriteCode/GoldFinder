using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldFinder.EntitySystem;
using System.IO;
using GoldFinder.Resources;

namespace GoldFinder.Saving
{
    public static class SaveManager
    {
        public static void SaveToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName == "") return;

            string path = saveFileDialog.FileName;
            string data = SerializeData();

            using(StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.Write(data);
            }
        }

        static string SerializeData()
        {
            string result = "";

            result += "<GoldfinderData>\n";

            foreach(Location location in LocationManager.locations)
            {
                result += SerializeLocation(location);
            }

            result += "</GoldfinderData>";

            return result;
        }

        static string SerializeLocation(Location location)
        {
            string result = "";

            result += "<Location>\n";
            result += $"<Name>\n{location.name}\n";

            foreach(Sublocation sublocation in location.subLocations)
            {
                result += SerializeSublocation(sublocation);
            }

            result += "</Location>\n";

            return result;
        }

        static string SerializeSublocation(Sublocation sublocation)
        {
            string result = "";

            result += "<Sublocation>\n";

            result += $"<Name>\n{sublocation.name}\n";

            foreach(Recipe recipe in sublocation.recipes)
            {
                result += "<Recipe>\n";

                result += $"<Name>\n{recipe.name}\n";

                foreach(Resource ingredient in recipe.ingredients)
                {
                    result += $"<Ingredient>\n{ingredient.name}\n{ingredient.amount}\n";
                }
                foreach(Resource output in recipe.output)
                {
                    result += $"<Output>\n{output.name}\n{output.amount}\n";
                }
                result += $"<WorkInfo>\n{recipe.workInfo.lowQualityWork}\n{recipe.workInfo.mediumQualityWork}\n{recipe.workInfo.highQualityWork}\n";

                result += "</Recipe>\n";
            }

            result += "</Sublocation>\n";

            return result;
        }
    }
}

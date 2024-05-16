using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldFinder.EntitySystem;
using System.Text.Json;
using System.IO;

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

            result += "<GoldfinderData>";

            foreach(Location location in LocationManager.locations)
            {
                result += SerializeLocation(location);
            }

            result += ">/GoldfinderData>";

            return result;
        }

        static string SerializeLocation(Location location)
        {
            string result = "";

            result += "<Location>";
            result += $"<Name>{location.name}</Name>";

            foreach(SubLocation sublocation in location.subLocations)
            {
                result += SerializeSublocation(sublocation);
            }

            result += "</Location>";

            return result;
        }

        static string SerializeSublocation(SubLocation sublocation)
        {
            string result = "";

            result += "<Sublocation>";
            result += $"<Name>{sublocation.name}</Name>";
            result += "</Sublocation>";

            return result;
        }
    }
}

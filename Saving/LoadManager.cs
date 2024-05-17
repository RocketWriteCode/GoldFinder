using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using GoldFinder.EntitySystem;
using GoldFinder.Resources;

namespace GoldFinder.Saving
{
    public static class LoadManager
    {
        public static void LoadFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName == "") return;

            string path = openFileDialog.FileName;
            string data;
            using(StreamReader inputFile = new StreamReader(path))
            {
                data = inputFile.ReadToEnd();
            }
            LocationManager.Clear();
            DeserializeData(data);
        }

        static void DeserializeData(string input)
        {
            string[] tokens = input.Split('\n');
            if (!ValidateData(tokens)) return;

            Stack<string> tokenStack = new Stack<string>();
            for(int i = tokens.Length - 1; i > 0; i--)
            {
                tokenStack.Push(tokens[i]);
            }

            while(tokenStack.Count > 0)
            {
                string currentString = tokenStack.Pop();

                switch (currentString)
                {
                    case "<Location>":
                        DeserializeLocation(tokenStack);
                        break;
                }
            }
        }

        static bool ValidateData(string[] input)
        {
            //actually validate the files once I know what's gonna be inside them
            return true;
        }

        static void DeserializeLocation(Stack<string> tokenStack)
        {
            string locationName = "NO LOCATION NAME FOUND!";
            List<Sublocation> sublocations = new List<Sublocation>();

            bool done = false;

            while(!done)
            {
                if(tokenStack.Count > 0)
                {
                    string currentString = tokenStack.Pop();
                    switch (currentString)
                    {
                        case "<Name>":
                            locationName = tokenStack.Pop();
                            break;
                        case "<Sublocation>":
                            sublocations.Add(DeserializeSublocation(tokenStack));
                            break;
                        case "</Location>":
                            done = true;
                            break;
                    }
                }
            }

            Location newLocation = new Location(locationName);
            foreach(Sublocation sublocation in sublocations)
            {
                newLocation.AddSublocation(sublocation);
            }

            LocationManager.AddLocation(newLocation);
        }

        static Sublocation DeserializeSublocation(Stack<string> tokenStack)
        {
            string sublocationName = "NO SUBLOCATION NAME FOUND!";
            bool done = false;

            List<Recipe> recipes = new List<Recipe>();

            while(!done)
            {
                string currentString = tokenStack.Pop();

                switch (currentString)
                {
                    case "<Name>":
                        sublocationName = tokenStack.Pop();
                        break;
                    case "<Recipe>":
                        recipes.Add(DeserializeRecipe(tokenStack));
                        break;
                    case "</Sublocation>":
                        done = true;
                        break;
                }
            }

            Sublocation sublocation = new Sublocation(sublocationName);
            sublocation.recipes = recipes;
            return sublocation;
        }

        static Recipe DeserializeRecipe(Stack<string> tokenStack)
        {
            bool done = false;
            Recipe recipe = new Recipe("RECIPE NAME NOT FOUND!");

            while(!done)
            {
                string currentString = tokenStack.Pop();

                switch(currentString)
                {
                    case "<Name>":
                        recipe.name = tokenStack.Pop();
                        break;
                    case "<Ingredient>":
                        Resource ingredient = new Resource(tokenStack.Pop());
                        recipe.ingredients.Add(ingredient);
                        break;
                    case "<Output>":
                        Resource output = new Resource(tokenStack.Pop());
                        recipe.output.Add(output);
                        break;
                    case "<WorkInfo>":
                        WorkInfo info = new WorkInfo(tokenStack.Pop(), tokenStack.Pop(), tokenStack.Pop());
                        recipe.workInfo = info;
                        break;
                    case "</Recipe>":
                        done = true;
                        break;
                }
            }

            return recipe;
        }
    }
}

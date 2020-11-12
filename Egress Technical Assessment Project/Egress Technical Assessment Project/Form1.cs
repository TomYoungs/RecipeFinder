using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Xml.XPath;

namespace Egress_Technical_Assessment_Project
{
    public partial class Form1 : Form
    {
    string apiKey = "00b9921a35f649a0bfcc4183b504d87f";
        private Recipe GetResponse(string baseUri, string requestUri)
        { 

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUri + requestUri + "&apiKey=" + apiKey);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var handler = new HttpClientHandler();
            var client = new HttpClient(handler);
            var rm = client.SendAsync(request).Result;
            string resultString = rm.Content.ReadAsStringAsync().Result;
            Recipe myDeserializedClass = new Recipe();
            myDeserializedClass = JsonConvert.DeserializeObject<Recipe>(resultString);
            return myDeserializedClass;
        }
        private void GetSearchIngredient(string searchInput){
            try
            {
                searchInput = searchInput.Replace(" ", "");
                string findByNameUri = "https://api.spoonacular.com/recipes/complexSearch";
                string userNameFindUri = "?includeIngredients=" + searchInput + "&addRecipeInformation=true&number=1";
                Recipe responceObject = GetResponse(findByNameUri, userNameFindUri);
                if (responceObject.TotalResults > 0)
                {
                    var newLine = System.Environment.NewLine;
                    var editedSummary = responceObject.Results[0].Summary;
                    editedSummary = editedSummary.Replace("<b>", "");
                    editedSummary = editedSummary.Replace("</b>", "");

                    searchTextBox.Text = responceObject.Results[0].Title + newLine + newLine +
                    responceObject.Results[0].SourceUrl + newLine + newLine +
                    editedSummary + newLine;
                    recipeImageBox.Load((responceObject.Results[0].Image).ToString());
                }
                else { searchTextBox.Text = "invalid ingredient try again"; }                   
            }
            catch (Exception e)
            {
                if (e.InnerException == null)
                    searchTextBox.Text = e.ToString();
                else
                    searchTextBox.Text = e.InnerException.ToString();
            }
        }
        private void GetSearchName(string searchInput) 
        {
            try
            {
                searchInput = searchInput.Replace(" ", "");
                string findByNameUri = "https://api.spoonacular.com/recipes/complexSearch";
                string userNameFindUri = "?query=" + searchInput + "&addRecipeInformation=true&number=1";
                Recipe responceObject = GetResponse(findByNameUri, userNameFindUri);
                if (responceObject.TotalResults > 0)
                {
                    var newLine = System.Environment.NewLine;
                    var editedSummary = responceObject.Results[0].Summary;
                    editedSummary = editedSummary.Replace("<b>", "");
                    editedSummary = editedSummary.Replace("</b>", "");

                    searchTextBox.Text = responceObject.Results[0].Title + newLine + newLine +
                    responceObject.Results[0].SourceUrl + newLine + newLine +
                    editedSummary + newLine;
                    recipeImageBox.Load((responceObject.Results[0].Image).ToString());
                }
                else { searchTextBox.Text = "invalid name try again"; }                    
            }
            catch (Exception e)
            {
                if (e.InnerException == null)
                    searchTextBox.Text = e.ToString();
                else
                    searchTextBox.Text = e.InnerException.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void beginSearch_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            if (searchInputBox.Text != "")
            {
                GetSearchIngredient(searchInputBox.Text);
                searchInputBox.Clear();
            }
            else if (searchInputBoxName.Text != "")
            {
                GetSearchName(searchInputBoxName.Text);
                searchInputBoxName.Clear();
            }
            else 
            { 
                searchTextBox.Text = ("please enter a search");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

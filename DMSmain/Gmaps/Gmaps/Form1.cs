using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMapRoute = GMap.NET.WindowsForms.GMapRoute;
//using Google.Type;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using static Nest.JoinField;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Gmaps
{
    public partial class Form1 : Form
    {
        List<PointLatLng> _points;
        List<string> path;
        //public object AppConfig { get; private set; }

        public Form1()
        {
            InitializeComponent();
            _points= new List<PointLatLng>();
            path= new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DFS START
            DFS g = new DFS(4);

            g.addEdge("UET", "Shalamar", 3);
            g.addEdge("UET", "GCU", 8);
            g.addEdge("UET", "PU", 15);
            g.addEdge("UET", "Queen Marry", 4);

            //g.addEdge("C", "E", 10);
            //g.addEdge("D", "E", 3);
            //g.addEdge("E", "F", 7);
            DFS_("UET" , g.adjList);

            //PRIMS SPANNING TREE
            int[,] graph = new int[,] { { 0, 2, 0, 6, 0 },
                                        { 2, 0, 3, 8, 5 },
                                        { 0, 3, 0, 0, 7 },
                                        { 6, 8, 0, 0, 9 },
                                        { 0, 5, 7, 9, 0 } };

            // Array to store the names of the vertices
            string[] vertexName = new string[] { "UET", "GCU", "PU", "Shlamar", "Queen Marry" };

            PrimsAlgorithm primsAlgorithm = new PrimsAlgorithm(graph, vertexName);
            // Print the solution
            primsAlgorithm.primMST();
            printMST(primsAlgorithm.parent, primsAlgorithm.vertices, primsAlgorithm.graph , primsAlgorithm.vertexName);
            //GMAPS STARTING
            _points.Clear();
            GMapProviders.GoogleMap.ApiKey = "AIzaSyCaOuZCFscGV4dBELoDiGO0Oku1gmPnBlg"; 
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.ShowCenter = false;
            gMapControl1.Zoom = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Enter Address 
            string Origin_Destination = textBox4.Text;
            path.Add(Origin_Destination);
            textBox4.Text = "";
            //Create a Geocoder Object
            Geocoder geocoder = new Geocoder();

            //Get the Latitude and Longitude
            string value = geocoder.GetLatLongFromAddress(Origin_Destination);
            string[] values = value.Split(',');
            textBox1.Text = values[0];
            textBox2.Text = values[1];
            gMapControl1.Position = new PointLatLng(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 8;
            var markers = new GMapOverlay("markers");
            var marker = new  GMarkerGoogle(new PointLatLng(Convert.ToDouble(textBox1.Text),Convert.ToDouble(textBox2.Text)), GMarkerGoogleType.green );
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(textBox1.Text) , Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 15);
            //double distance = route.Distance;
            //textBox3.Text = distance.ToString();
            GMapRoute r = new GMapRoute(route.Points, "My route");
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            gMapControl1.Overlays.Add(routesOverlay);


            textBox3.Text = Convert.ToInt32(route.Distance).ToString()+" Kilometers";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = path[0] +" TO "+ path[1];
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
        public void printMST(int[] parent, int n, int[,] graph, string[] vertexName)
        {
            textBox5.Text = "Edge   Weight";
            textBox5.AppendText(Environment.NewLine);
            for (int i = 1; i < n; i++)
            {
                textBox5.AppendText(vertexName[parent[i]] + " - " + vertexName[i] + "   " + graph[i, parent[i]]);
                textBox5.AppendText(Environment.NewLine);
            }
        }

        public void DFS_(string startVertex , Dictionary<string, List<Tuple<string, int>>> adjList)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            Stack<string> stack = new Stack<string>();
            stack.Push(startVertex);
            textBox6.Text = "SEQUENCE OF ROUTE";
            while (stack.Count != 0)
            {
                string currentVertex = stack.Pop();
                if (!visited.ContainsKey(currentVertex))
                {
                    textBox6.AppendText(currentVertex + " ");
                    textBox6.AppendText(Environment.NewLine);
                    visited.Add(currentVertex, true);
                    if (adjList.ContainsKey(currentVertex))
                    {
                        foreach (Tuple<string, int> neighbour in adjList[currentVertex])
                        {
                            stack.Push(neighbour.Item1);
                        }
                    }
                }
            }
        }
    }
    public class Geocoder
    {
        public string GetLatLongFromAddress(string address)
        {
            //Create the request string and encode the address
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={Uri.EscapeDataString(address)}&key=AIzaSyCaOuZCFscGV4dBELoDiGO0Oku1gmPnBlg";

            //Make the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            //Parse the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //Deserialize the response into a LatLong object
            string value = Newtonsoft.Json.JsonConvert.DeserializeObject(json).ToString();
            //double lat = (double)JObject.Parse(json)["location"]["lat"];
            //double lng = (double)JObject.Parse(json)["location"]["lng"];
            // Create a JObject from the JSON string
            //JObject jsonObject = JObject.Parse(json);

            // Get the latitude value from the JSON
            //double latitude = (double)jsonObject["location"]["lat"];

            // Get the longitude value from the JSON
            //double longitude = (double)jsonObject["location"]["lng"];
            //var js = JObject.Parse(json);

            // get the values of lat and lng
            //var lat = js.Value<double>("lat").ToString();
            //var lng = js.Value<double>("lng");

            JObject jsonObject = JObject.Parse(value);
            double latitude = (double)jsonObject["results"][0]["geometry"]["location"]["lat"];

            double longitude = (double)jsonObject["results"][0]["geometry"]["location"]["lng"];
            string lat = latitude.ToString() +","+ longitude.ToString();

            return lat;
        }
    }
}

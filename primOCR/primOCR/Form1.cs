using Microsoft.VisualBasic;
using System.Drawing;

namespace primOCR
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        int otherCost = 0;
        int connections = 0;
        Vertex temp;

        private List<string> recommendations = new List<string>();
        Graph graph = new Graph();
        ActivityStack activityStack = new ActivityStack();
        public Form1()
        {

            InitializeComponent();
            pointA.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            pointA.AutoCompleteMode = AutoCompleteMode.Suggest;
            pointA.AutoCompleteSource = AutoCompleteSource.CustomSource;
            pointB.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            pointB.AutoCompleteMode = AutoCompleteMode.Suggest;
            pointB.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }
        public void updateThisCost(int other = 0)
        {
            int displayCost = 0;
            displayCost += getObstacleCost();
            displayCost += getDistance();
            displayCost += other;
            thisCostlbl.Text = ("This Connection Cost : " + displayCost);
        }
        public int getDistance()
        {
            if (distanceBox.Text == "")
            {
                return 0;
            }
            else
            {
                int distance = int.Parse(distanceBox.Text) * 100;
                return distance;
            }
        }

        private void distanceBox_TextChanged(object sender, EventArgs e)
        {
            string distanceBoxText = distanceBox.Text;
            if (distanceBoxText != "")
            {
                updateThisCost();
            }

        }
        public void save()
        {
            if (pointA.Text == "" || pointB.Text == "")
            {
                MessageBox.Show("You haven't Entered InValid City Name\n\nCity Names Cant be Empty", "Invalid Names");
            }
            else if (int.TryParse(pointA.Text, out int integerValue) || int.TryParse(pointB.Text, out int integerValue2))
            {
                MessageBox.Show("You haven't Entered InValid City Name\n\nCity Names Cant be Numbers", "Invalid Names");
            }
            else
            {
                int displayCost = 0;
                displayCost += getObstacleCost();
                displayCost += getDistance();
                displayCost += otherCost;
                Vertex vertex1 = graph.GetVertex(pointA.Text);
                Vertex vertex2 = graph.GetVertex(pointB.Text);
                if (vertex1 == null || vertex2 == null)
                {
                    totalCost += displayCost;
                    totalCostlbl.Text = ("Total Cost : " + totalCost);
                    totalConnection.Text = ("Total Connections : " + (++connections));
                }
                if (vertex1 == null)
                {
                    vertex1 = new Vertex(pointA.Text);
                    graph.AddVertex(vertex1);

                }

                if (vertex2 == null)
                {
                    vertex2 = new Vertex(pointB.Text);
                    graph.AddVertex(vertex2);
                    activityStack.newVertix = true;
                }

                recommendations.Add(vertex1.Name);
                recommendations.Add(vertex2.Name);
                pointA.AutoCompleteCustomSource.AddRange(recommendations.ToArray());
                pointB.AutoCompleteCustomSource.AddRange(recommendations.ToArray());
                vertex1.AddEdge(vertex2, displayCost);
                graph.DisplayGraph(this);
                connectionsPanel.Invalidate();
            }
        }
        public int getObstacleCost()
        {
            int obstacleCost = 0;
            if (mountain.Checked == true)
            {
                obstacleCost += 300000;
            }
            if (river.Checked == true)
            {
                obstacleCost += 40000;
            }
            if (res.Checked == true)
            {
                obstacleCost += 990000;
            }
            if (forest.Checked == true)
            {
                obstacleCost += 20000;
            }
            return obstacleCost;
        }

        private void mountain_CheckedChanged(object sender, EventArgs e)
        {
            updateThisCost();
        }

        private void river_CheckedChanged(object sender, EventArgs e)
        {
            updateThisCost();
        }

        private void res_CheckedChanged(object sender, EventArgs e)
        {
            updateThisCost();
        }

        private void forest_CheckedChanged(object sender, EventArgs e)
        {
            updateThisCost();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                int x = int.Parse(Interaction.InputBox("Provide the cost for your Other Obstacle", "Custom Cost", "0"));
                otherCost = x;
                updateThisCost(x); ;
            }
            if (checkBox5.Checked == false)
            {
                int x = 0;
                updateThisCost(x); ;
                otherCost = 0;
            }

        }
        public void updateConnections(string info)
        {
            this.connectiontxt.Text = info;
        }
        public void updatePrimsConnections(string info)
        {
            this.primsConnections.Text = info;
        }

        private void connectionsPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Calculate positions for vertices (example)
            Dictionary<string, Point> vertexPositions = CalculateVertexPositions();

            foreach (var vertex in graph.vertices)
            {
                Point vertexPos = vertexPositions[vertex.Name];

                // Draw vertices (circles)
                g.FillEllipse(Brushes.Black, vertexPos.X - 10, vertexPos.Y - 10, 20, 20);

                // Display vertex names
                g.DrawString(vertex.Name, Font, Brushes.Black, vertexPos.X - 10, vertexPos.Y - 25);

                // Draw edges
                foreach (var edge in vertex.Edges)
                {
                    Point connectedVertexPos = vertexPositions[edge.Key.Name];

                    // Draw edge line
                    g.DrawLine(Pens.Black, vertexPos, connectedVertexPos);

                    // Display weight along the edge
                    string weightText = edge.Value.ToString();
                    Point weightPos = new Point((vertexPos.X + connectedVertexPos.X) / 2, (vertexPos.Y + connectedVertexPos.Y) / 2);
                    g.DrawString(weightText, Font, Brushes.Black, weightPos.X, weightPos.Y);
                }
            }
        }

        private Dictionary<string, Point> CalculateVertexPositions()
        {
            Dictionary<string, Point> vertexPositions = new Dictionary<string, Point>();

            int panelWidth = connectionsPanel.Width;
            int panelHeight = connectionsPanel.Height;

            int vertexCount = graph.vertices.Count;
            double angleIncrement = 2 * Math.PI / vertexCount;
            double currentAngle = 0;

            int circleCenterX = panelWidth / 2;
            int circleCenterY = panelHeight / 2;
            int circleRadius = Math.Min(panelWidth, panelHeight) / 3;

            foreach (var vertex in graph.vertices)
            {
                int x = circleCenterX + (int)(circleRadius * Math.Cos(currentAngle));
                int y = circleCenterY + (int)(circleRadius * Math.Sin(currentAngle));

                vertexPositions[vertex.Name] = new Point(x, y);

                currentAngle += angleIncrement;
            }

            return vertexPositions;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void obstacles_Enter(object sender, EventArgs e)
        {

        }

        private void primsVisual_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Dictionary<string, Point> vertexPositions = CalculateVertexPositions();

            foreach (var vertex in graph.vertices)
            {
                Point vertexPos = vertexPositions[vertex.Name];

                g.FillEllipse(Brushes.Black, vertexPos.X - 10, vertexPos.Y - 10, 20, 20);
                g.DrawString(vertex.Name, Font, Brushes.Black, vertexPos.X - 10, vertexPos.Y - 25);
            }

            List<Tuple<string, string, int>> minimumSpanningTree = graph.CalculateMSTUsingPrim();

            foreach (var edge in minimumSpanningTree)
            {
                Point vertexAPos = vertexPositions[edge.Item1];
                Point vertexBPos = vertexPositions[edge.Item2];

                g.DrawLine(Pens.Red, vertexAPos, vertexBPos);
                // Display edge weight if needed
                string weightText = edge.Item3.ToString();
                Point weightPos = new Point((vertexAPos.X + vertexBPos.X) / 2, (vertexAPos.Y + vertexBPos.Y) / 2);
                g.DrawString(weightText, Font, Brushes.Black, weightPos.X, weightPos.Y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = graph.totalweight;
            primsCost.Text = ("Total Cost After Prims :" + x);
            removed.Invalidate();
            primsVisual.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activityStack.undo(graph);
            graph.DisplayGraph(this);
            connectionsPanel.Invalidate();

        }

        private void connectiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void primsVisual_Paint_1(object sender, PaintEventArgs e)
        {


        }
    }
}
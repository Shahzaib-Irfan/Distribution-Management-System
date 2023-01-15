// Lab13Graphs.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <conio.h>
#include <fstream>
#include <vector>
using namespace std;

class CS261Vertex
{
public:
    vector<CS261Vertex*> inNeighbors;
    vector<CS261Vertex*> outNeighbors;
    int value;
    // useful for DFS
    int inTime;
    int outTime;
    string status;

    CS261Vertex(int v)
    {
        value = v;
        inTime = 0;
        outTime = 0;
        status = "unvisited";
    }

    bool hasOutNeighbor(CS261Vertex* v)
    {
        for (int i = 0; i < outNeighbors.size(); i++)
        {
            if (outNeighbors[i] == v)
            {
                return true;
            }
        }
        return false;
    }

    bool hasInNeighbor(CS261Vertex* v)
    {
        for (int i = 0; i < inNeighbors.size(); i++)
        {
            if (inNeighbors[i] == v)
            {
                return true;
            }
        }
        return false;
    }

    bool hasNeighbor(CS261Vertex* v)
    {
        if (hasOutNeighbor(v) || hasInNeighbor(v))
        {
            return true;
        }
        return false;
    }

    vector<CS261Vertex*> getOutNeighbors()
    {
        return outNeighbors;
    }

    vector<CS261Vertex*> getInNeighbors()
    {
        return inNeighbors;
    }

    void addOutNeighbor(CS261Vertex* v)
    {
        outNeighbors.push_back(v);
    }

    void addInNeighbor(CS261Vertex* v)
    {
        inNeighbors.push_back(v);
    }
};

class CS261Graph
{
public:
    vector<CS261Vertex*> vertices;

    void addVertex(CS261Vertex* n)
    {
        vertices.push_back(n);
    }

    void addDiEdge(CS261Vertex* u, CS261Vertex* v)
    {
        u->addOutNeighbor(v);
        v->addInNeighbor(u);
    }

    void addBiEdge(CS261Vertex* u, CS261Vertex* v)
    {
        addDiEdge(u, v);
        addDiEdge(v, u);
    }

    vector<vector<CS261Vertex*>> getDirEdges()
    {
        vector<vector<CS261Vertex*>> ret;
        for (int i = 0; i < vertices.size(); i++)
        {
            CS261Vertex* v = vertices[i];
            for (int j = 0; j < v->outNeighbors.size(); j++)
            {
                vector<CS261Vertex*> edge;
                edge.push_back(v);
                edge.push_back(v->outNeighbors[j]);
                ret.push_back(edge);
            }
        }
        return ret;
    }

    string __convertToString__()
    {
        string ret = "CS261Graph with:\n";
        ret += "\t Vertices:\n\t";
        for (int i = 0; i < vertices.size(); i++)
        {
            ret += vertices[i]->value + ',';
        }
        ret += "\n";
        ret += "\t Edges:\n\t";
        vector<vector<CS261Vertex*>> edges = getDirEdges();
        for (int i = 0; i < edges.size(); i++)
        {

            ret += "(" + edges[i][0]->value + ',' + edges[i][1]->value + ')';
        }
        ret += "\n";
        return ret;
    }
};

int main()
{
    CS261Graph G;
    for (int i = 0; i < 10; i++)
    {
        G.addVertex(new CS261Vertex(i));
    }
    vector<CS261Vertex*> V = G.vertices;
    for (int i = 0; i < 9; i++)
    {
        G.addDiEdge(V[i], V[i + 1]);
    }
    cout << G.__convertToString__() << endl;
    //return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

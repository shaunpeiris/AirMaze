using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Request
/// </summary>
public class Request
{
    private int r_ID;
    private int author_ID;
    private string p_Name;
    private int loc_ID;
    private string postal_Code;
    private double pRangeStart;
    private double pRangeEnd;
    private string rdesc;
    private string rremarks;
    private string rdate;
    string _connStr = ConfigurationManager.ConnectionStrings["airmazin"].ConnectionString;

    public Request()
    {

    }
    public Request(int rID, int authorId, string prodName, int locID, string postCode, double pRStart, double pREnd, string pDesc, string pRemarks, string pDate)
    {
        this.r_ID = rID;
        this.author_ID = authorId;
        this.p_Name = prodName;
        this.locationID = locID;
        this.postal_Code = postCode;
        this.pRangeStart = pRStart;
        this.pRangeEnd = pREnd;
        this.rdesc = pDesc;
        this.rremarks = pRemarks;
        this.rdate = pDate;
    }

    public int requestID
    {
        get { return r_ID; }
        set { r_ID = value; }
    }

    public int authorID
    {
        get { return author_ID; }
        set { author_ID = value; }
    }

    public string productName
    {
        get { return p_Name; }
        set { p_Name = value; }
    }

    public int locationID
    {
        get { return loc_ID; }
        set { loc_ID = value; }
    }

    public string postalCode
    {
        get { return postal_Code; }
        set { postal_Code = value; }
    }

    public double priceRangeStart
    {
        get { return pRangeStart; }
        set { pRangeStart = value; }
    }

    public double priceRangeEnd
    {
        get { return pRangeEnd; }
        set { pRangeEnd = value; }
    }

    public string description
    {
        get { return rdesc; }
        set { rdesc = value; }
    }

    public string remarks
    {
        get { return rremarks; }
        set { rremarks = value; }
    }

    public string datePosted
    {
        get { return rdate; }
        set { rdate = value; }
    }

    public List<Request> getAllRequests()
    {
        List<Request> all = new List<Request>();

        string queryStr = "SELECT * FROM Request Order By requestID";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            string rID = dr["requestID"].ToString();
            string auID = dr["authorID"].ToString();
            string pname = dr["productName"].ToString();
            string locID = dr["locationID"].ToString();
            string posCode = dr["postalCode"].ToString();
            string prs = dr["priceRangeStart"].ToString();
            string pre = dr["priceRangeEnd"].ToString();
            string desc = dr["description"].ToString();
            string rmks = dr["remarks"].ToString();
            string dateposted = dr["datePosted"].ToString();

            Request req = new Request(Int32.Parse(rID), Int32.Parse(rID), pname, Int32.Parse(locID), posCode, Double.Parse(prs), Double.Parse(pre), desc, rmks, dateposted);
            all.Add(req);
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return all;
    }
}
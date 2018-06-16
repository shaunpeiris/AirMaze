using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for RequestDA
/// </summary>
public static class RequestDA
{

    private static string _connStr = ConfigurationManager.ConnectionStrings["airmazin"].ConnectionString;

    public static List<Request> getAllRequests()
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

            Request req = new Request(Int32.Parse(rID), Int32.Parse(auID), pname, Int32.Parse(locID), posCode, Double.Parse(prs), Double.Parse(pre), desc, rmks, dateposted);
            all.Add(req);
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return all;
    }

    public static Request getRequestByProductID(int productid)
    {
        string queryStr = "SELECT * FROM [Request] INNER JOIN [ProductPhoto] on [Request].requestID = [ProductPhoto].requestID WHERE [Request].requestID = @productid";

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["airmazin"].ConnectionString);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@productid", productid);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        int rID = 0;
        int authorId = 0;
        string prodName = "";
        int locID = 0;
        string postCode = "";
        double pRStart = 0.0;
        double pREnd = 0.0;
        string pDesc = "";
        string pRemarks = "";
        string pDate = "";


        while (dr.Read())
        {
            rID = int.Parse(dr["requestID"].ToString());
            authorId = int.Parse(dr["authorID"].ToString());
            prodName = dr["productName"].ToString();
            locID = int.Parse(dr["locationID"].ToString());
            postCode = dr["postalCode"].ToString();
            pRStart = double.Parse(dr["priceRangeStart"].ToString());
            pREnd = double.Parse(dr["priceRangeEnd"].ToString());
            pDesc = dr["description"].ToString();
            pRemarks = dr["remarks"].ToString();
            pDate = dr["datePosted"].ToString();
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return new Request(rID, authorId, prodName, locID, postCode, pRStart, pREnd, pDesc, pRemarks, pDate);
    }

    public static string getRequestAuthorName(int userid)
    {
        string queryStr = "SELECT [username] FROM [User] WHERE [User].userID = @id";

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["airmazin"].ConnectionString);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@id", userid);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        string username = "";

        while (dr.Read())
        {
            username = dr["username"].ToString();
        }
        return username;
    }

    public static string getLocation(int locid)
    {
        string queryStr = "SELECT * FROM [Location] WHERE locationID = @locid";

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["airmazin"].ConnectionString);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@locid", locid);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        String location = "";

        while (dr.Read())
        {
            location = dr["cityName"].ToString() + ", " + dr["stateName"].ToString() + ", " + dr["countryName"].ToString();
        }

        if (location.Contains("Singapore"))
        {
            location = "Singapore";
        }

        return location;
    }

    public static List<string> getRequestPhotosURL(int rID)
    {
        return null; 
    }
}
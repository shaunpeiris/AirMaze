using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


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

}
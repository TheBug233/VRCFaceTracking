﻿namespace VRCFaceTracking.Core.Models;

// Model for the SampleDataService. Replace with your own model.
public class RemoteTrackingModule
{
    public Guid ModuleId
    {
        get; set;
    }

    public DateTime LastUpdated
    {
        get; set;
    }
    
    public string Version
    {
        get; set;
    }
    
    public int Downloads
    {
        get; set;
    }
    
    public int Ratings
    {
        get; set;
    }
    
    public int Rating
    {
        get; set;
    }

    public string AuthorName
    {
        get; set;
    }

    public string ModuleName
    {
        get; set;
    }
    
    public string ModuleDescription
    {
        get; set;
    } = "(No description provided)";
    
    public string UsageInstructions
    {
        get; set;
    } = "(No usage instructions provided. Check the module page for more information.)";

    public string DownloadUrl
    {
        get; set;
    }

    public string ModulePageUrl
    {
        get;
        set;
    } = "(No page provided)";
}
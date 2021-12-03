using CalendarProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarProject.Controllers.ScheduleController
{
    public partial class ScheduleController : Controller
    {
        public IActionResult TimelineResourceGroup()
        {
            ScheduleData data = new ScheduleData();
            List<ScheduleData.ResourceData> resourceData = data.GetResourceData();
            List<ScheduleData.ResourceData> timelineResourceData = data.GetTimelineResourceData();
            ViewBag.datasource = resourceData.Concat(timelineResourceData);

            // Camions vue Utilisateurs (GROUP) 
            List<ResourceDataSourceModel> projects = new List<ResourceDataSourceModel>();
            projects.Add(new ResourceDataSourceModel { text = "MERCEDES 4 essieux - VS 313213", id = 1, color = "#cb6bb2" });
            projects.Add(new ResourceDataSourceModel { text = "Mercedes 460 3essieux - VS 120661", id = 2, color = "#56ca85" });
            projects.Add(new ResourceDataSourceModel { text = "Mercedes 460 3essieux thermos - VS 120661", id = 3, color = "#df5286" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux multilift VS 362651", id = 4, color = "#0a86f9" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux malaxeur VS 362651", id = 5, color = "#df5286" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux Thermos VS 362651", id = 6, color = "#b10af9" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux VS 362651", id = 7, color = "#21f90a" });
            projects.Add(new ResourceDataSourceModel { text = "SCANIA 5 essieux VS 375314", id = 8, color = "#df5286" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux VS 389617 Thermos", id = 9, color = "#f3f90a" });
            ViewBag.Projects = projects;

            // Utilisateurs vue Utilisateurs (GROUP)
            List<ResourceDataSourceModel> categories = new List<ResourceDataSourceModel>();
            categories.Add(new ResourceDataSourceModel { text = "1", id = 1, groupId = 1, color = "#df5286" });
            categories.Add(new ResourceDataSourceModel { text = "2", id = 2, groupId = 1, color = "#7fa900" });
            categories.Add(new ResourceDataSourceModel { text = "3", id = 3, groupId = 2, color = "#ea7a57" });
            categories.Add(new ResourceDataSourceModel { text = "4", id = 4, groupId = 2, color = "#5978ee" });
            categories.Add(new ResourceDataSourceModel { text = "5", id = 5, groupId = 3, color = "#0af9af" });
            categories.Add(new ResourceDataSourceModel { text = "6", id = 6, groupId = 4, color = "#00bdae" });
            categories.Add(new ResourceDataSourceModel { text = "7", id = 7, groupId = 5, color = "#f9a50a" });
            categories.Add(new ResourceDataSourceModel { text = "8", id = 8, groupId = 6, color = "#0a79f9" });
            categories.Add(new ResourceDataSourceModel { text = "9", id = 9, groupId = 7, color = "#b10af9" });
            categories.Add(new ResourceDataSourceModel { text = "10", id = 10, groupId = 8, color = "#f90aa0" });
            ViewBag.Categories = categories;

            ViewBag.Resources = new string[] { "Projects", "Categories" };
            ViewBag.workDays = new int[] { 0, 1, 2, 3, 4, 5 };
            return View();
        }

        public IActionResult TimelineResourceCategories()
        {
            ScheduleData data = new ScheduleData();
            List<ScheduleData.ResourceData> resourceData = data.GetResourceData();
            List<ScheduleData.ResourceData> timelineResourceData = data.GetTimelineResourceData();
            ViewBag.datasource = resourceData.Concat(timelineResourceData);

            // Camions vue Camions (CATEGORIES)
            List<ResourceDataSourceModel> projects = new List<ResourceDataSourceModel>();
            projects.Add(new ResourceDataSourceModel { text = "MERCEDES 4 essieux - VS 313213", id = 1, color = "#00d600" });
            projects.Add(new ResourceDataSourceModel { text = "Mercedes 460 3essieux - VS 120661", id = 2, color = "#52ffff" });
            projects.Add(new ResourceDataSourceModel { text = "Mercedes 460 3essieux thermos - VS 120661", id = 3, color = "#d1d100" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux multilift VS 362651", id = 4, color = "#df5286" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux malaxeur VS 362651", id = 5, color = "#f90a92" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux Thermos VS 362651", id = 6, color = "#0a24f9" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux VS 362651", id = 7, color = "#008000" });
            projects.Add(new ResourceDataSourceModel { text = "SCANIA 5 essieux VS 375314", id = 8, color = "#ffbdde" });
            projects.Add(new ResourceDataSourceModel { text = "Man 480 4 essieux VS 389617 Thermos", id = 9, color = "#f90aa0" });
            ViewBag.Projects = projects;


            string[] resources = new string[] { "Projects" };
            ViewBag.workDays = new int[] { 0, 1, 2, 3, 4, 5 };
            ViewBag.Resource = resources;
            return View();
        }
    }
}

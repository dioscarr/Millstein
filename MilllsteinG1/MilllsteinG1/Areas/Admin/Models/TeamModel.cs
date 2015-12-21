using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MilllsteinG1.Areas.Admin.Models;
using DAL.Models;
using BLL;
using System.ComponentModel.DataAnnotations;


namespace MilllsteinG1.Areas.Admin.Models
{
    public class TeamModel:BaseModel
    {
        public Team team { get; set;}
        public List<Team> teamList { get; set;}
        public Advisory advisory { get; set; }
        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageUpload { get; set; }
        public TeamModel()
        {
            teamList = ManageTeam.GetAllTeam().ToList();
            advisory = ManageAdvisory.GetAllAdvisory().FirstOrDefault();
            team = null;
        }
        public void Load(int id)
        {
            team = ManageTeam.GetById(id);
        }


        internal void updateAdvisoryOverview(TeamModel model)
        {           
            ManageAdvisory.UpdateAdvisory(model.advisory);
        }

        


        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MilllsteinG1.Models;
using DAL.Models;
using BLL;


namespace MilllsteinG1.Models
{
    public class TeamModel:BaseModel
    {
        public Team team { get; set;}
        public List<Team> teamList { get; set;}
        public Advisory advisory { get; set; }
        public TeamModel()
        {
            teamList = ManageTeam.GetAllTeam().Where(c=>c.Type=="advisor").ToList();
            advisory = ManageAdvisory.GetAllAdvisory().FirstOrDefault();
            team = null;
        }
        public void LoadAllManagement()
        {
            teamList = ManageTeam.GetAllTeam().Where(u => u.Type == "manage").ToList();
        }

        public void Load(int id)
        {
            team = ManageTeam.GetById(id);
        }
        
    }
}
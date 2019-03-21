﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BP2Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LECDBEntities : DbContext
    {
        public LECDBEntities()
            : base("name=LECDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<AnalyticalCaster> AnalyticalCasters { get; set; }
        public virtual DbSet<Caster> Casters { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Host> Hosts { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<MatchTicket> MatchTickets { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Standing> Standings { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamStaff> TeamStaffs { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorksForTeam> WorksForTeams { get; set; }
    
        public virtual int FreeSeatProcedure(Nullable<int> row, Nullable<int> seat, string matchName)
        {
            var rowParameter = row.HasValue ?
                new ObjectParameter("row", row) :
                new ObjectParameter("row", typeof(int));
    
            var seatParameter = seat.HasValue ?
                new ObjectParameter("seat", seat) :
                new ObjectParameter("seat", typeof(int));
    
            var matchNameParameter = matchName != null ?
                new ObjectParameter("matchName", matchName) :
                new ObjectParameter("matchName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FreeSeatProcedure", rowParameter, seatParameter, matchNameParameter);
        }
    
        public virtual int UpdateStandings(Nullable<int> teamID, Nullable<int> wins, Nullable<int> loses)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            var winsParameter = wins.HasValue ?
                new ObjectParameter("wins", wins) :
                new ObjectParameter("wins", typeof(int));
    
            var losesParameter = loses.HasValue ?
                new ObjectParameter("loses", loses) :
                new ObjectParameter("loses", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStandings", teamIDParameter, winsParameter, losesParameter);
        }
    }
}
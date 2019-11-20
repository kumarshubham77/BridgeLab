﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.AdminModels;
using Common.Models.Collaborator;
using Common.Models.LabelModels;
using Common.Models.NotesModels;
using Common.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace FundooRepository.Context
{
    /// <summary>
    /// Creating a class UserContext that will inherit the DbContext class.
    /// To use DbContext in our application, we need to create the class that derives from
    /// DbContext, also known as context class. This context class typically includes
    /// DbSet<TEntity> properties for each entity in the model.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class UserContexts:DbContext
    {

        public UserContexts(DbContextOptions<UserContexts> options):base(options)
        {

        }
        /// <summary>
        /// A DbSet represents the collection of all entities in the context, or that can be queried from the
        /// database, of a given type. DbSet objects are created from a DbContext using the DbContext.Set mehtod.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        //public DbSet<UserModel> users { get; set; }
       public DbSet<NotesModel> notes { get; set; }
       public DbSet<LabelModel> labels { get; set; }
       public DbSet<CollaboratorModels> collaborator { get; set; }
        public DbSet<UserModel> user { get; set; }

        public DbSet<AdminModel> admin { get; set; }
        public DbSet<AdminUserDetails> adminuserdetails { get; set; }

    }
}

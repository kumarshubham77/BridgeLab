// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Context
{
    /// <summary>
    /// Creating a class UserContext that will inherit the DbContext class.
    /// To use DbContext in our application, we need to create the class that derives from
    /// DbContext, also known as context class. This context class typically includes
    /// DbSet<TEntity> properties for each entity in the model.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class UserContext:DbContext
    {

        public UserContext(DbContextOptions<UserContext> options):base(options)
        {

        }
        /// <summary>
        /// A DbSet represents the collection of all entities in the context, or that can be queried from the
        /// database, of a given type. DbSet objects are created from a DbContext using the DbContext.Set mehtod.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public DbSet<UserModel> users { get; set; }
    }
}

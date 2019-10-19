// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HotelFacade.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.StructuralDesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// Creating a class HotelFacade.
    /// </summary>
    public class HotelFacade
    {
        Veg menu1;
        NonVeg menu2;
        BothNonVegandVeg menu3;
        /// <summary>
        /// Creating a Constructor of the HotelFacade.
        /// Initializes a new instance of the <see cref="HotelFacade"/> class.
        /// </summary>
        public HotelFacade()
        {
            menu1 = new Veg();
            menu2 = new NonVeg();
            menu3 = new BothNonVegandVeg();
        }
        /// <summary>
        /// Calling every class methods.
        /// </summary>
        public void FullStructureHotel()
        {
            menu1.Vegetarian();
            menu2.Nonvegetarian();
            menu3.Both();
        }
    }
}

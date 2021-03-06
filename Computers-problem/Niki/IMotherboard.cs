﻿// <copyright file="IMotherboard.cs" company="Unknown">
// Copyright(c) 2015 Team "Unknown"
// </copyright>
// <summary>
// IMotherboard interface
// </summary>
// <author>Unknown</author>

namespace Computers.UI.Console
{

    /// <summary>
    ///     Represents motherboard functionality
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        ///     The method for loading ram
        /// </summary>
        /// <returns>int value</returns>
        int LoadRamValue();

        /// <summary>
        ///     The method for saving ram
        /// </summary>
        /// <param name="value">The int to save</param>
        void SaveRamValue(int value);

        /// <summary>
        ///     The method for drawing on video card
        /// </summary>
        /// <param name="data">The string/text to draw</param>
        void DrawOnVideoCard(string data);
    }

}
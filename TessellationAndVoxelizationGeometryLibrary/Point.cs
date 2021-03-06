﻿// ***********************************************************************
// Assembly         : TessellationAndVoxelizationGeometryLibrary
// Author           : Matt
// Created          : 06-05-2015
//
// Last Modified By : Matt
// Last Modified On : 06-05-2015
// ***********************************************************************
// <copyright file="Point2D.cs" company="">
//     Copyright ©  2014
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using MIConvexHull;
using TVGL.Tessellation;

namespace TVGL
{
    /// <summary>
    /// The Point class is used to indicate a 2D or 3D location that may be outside
    /// of a solid (hence making Vertex an inappropriate choice). 
    /// One of the useful aspects of the point object is that they contain a 
    /// reference (or References) to vertices that may be representing in a 
    /// transformed way. For example "Get2DProjection" returns the 2D projection of
    /// a set of vertices without changing those vertices. This is done by "wrapping"
    /// these Point objects around a vertex and then providing their new position. 
    /// </summary>
    public class Point : IVertex
    {
        private IVertex v;

        #region Properties

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the z coordinate. If one is using Point in a 2D capacity, it can be ignored.
        /// </summary>
        /// <value>The z.</value>
        public double Z { get; set; }

        /// <summary>
        /// Gets or sets the references.
        /// </summary>
        /// <value>The references.</value>
        public List<Vertex> References { get; set; }

        /// <summary>
        /// Gets or sets the coordinates or position.
        /// </summary>
        /// <value>The coordinates or position.</value>
        public double[] Position
        {
            get { return new[] { X, Y, Z }; }
            set
            {
                X = value[0];
                Y = value[1];
                if (value.GetLength(0) > 2)
                    Z = value[2];
                else Z = 0.0;
            }
        }

        /// <summary>
        /// Gets or sets the coordinates or position.
        /// </summary>
        /// <value>The coordinates or position.</value>
        public double[] Position2D
        {
            get { return new[] { X, Y }; }
            set
            {
                X = value[0];
                Y = value[1];
                if (value.GetLength(0) > 2)
                    throw new Exception("Cannot set the value of a point with an array with more than 2 values.");
                 Z = 0.0;
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="v">The v.</param>
        public Point(Vertex v)
            : this(v, v.Position[0], v.Position[1], v.Position[2])
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Point(Vertex vertex, double x, double y)
            : this(vertex, x, y, 0.0)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        public Point(Vertex vertex, double x, double y, double z)
        {
            References = new List<Vertex> { vertex };
            X = x;
            Y = y;
            Z = z;
        }
        public double this[int index]
        {
            get { return Position[index]; }
        }


        #endregion
    }
}
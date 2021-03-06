﻿using System;
using System.Collections.Generic;
using System.Linq;
using StarMathLib;
using TVGL.Tessellation;

namespace TVGL
{
    /// <summary>
    /// Class Sphere.
    /// </summary>
    public class Sphere : PrimitiveSurface
    {
        #region Constructor
        public Sphere(IEnumerable<PolygonalFace> facesAll)
            : base(facesAll)
        {
            var faces = ListFunctions.FacesWithDistinctNormals(facesAll.ToList());
            var n = faces.Count;
            var centers = new List<double[]>();
            double[] center;
            double t1, t2;
            var signedDistances = new List<double>();
            GeometryFunctions.SkewedLineIntersection(faces[0].Center, faces[0].Normal,
               faces[n - 1].Center, faces[n - 1].Normal, out center, out t1, out t2);
            if (!center.Any(double.IsNaN) || StarMath.IsNegligible(center))
            {
                centers.Add(center);
                signedDistances.Add(t1);
                signedDistances.Add(t2);
            }
            for (var i = 1; i < n; i++)
            {
                GeometryFunctions.SkewedLineIntersection(faces[i].Center, faces[i].Normal,
                   faces[i - 1].Center, faces[i - 1].Normal, out center, out t1, out t2);
                if (!center.Any(double.IsNaN) || StarMath.IsNegligible(center))
                {
                    centers.Add(center);
                    signedDistances.Add(t1);
                    signedDistances.Add(t2);
                }
            }
            center = new double[3];
            center = centers.Aggregate(center, (current, c) => current.add(c));
            center = center.divide(centers.Count);
            /* determine is positive or negative */
            var numNeg = signedDistances.Count(d => d < 0);
            var numPos = signedDistances.Count(d => d > 0);
            var isPositive = (numNeg > numPos);
            var radii = new List<double>();
            foreach (var face in faces)
                radii.AddRange(face.Vertices.Select(v => GeometryFunctions.DistancePointToPoint(v.Position, center)));
            var averageRadius = radii.Average();

            Center = center;
            IsPositive = isPositive;
            Radius = averageRadius;         
        }

        internal Sphere(Edge edge)
            : this(new List<PolygonalFace>(new[] {edge.OwnedFace, edge.OtherFace}))
        {
        }

        #endregion                   
        /// <summary>
        /// Is the sphere positive? (false is negative)
        /// </summary>
        public Boolean IsPositive;
        /// <summary>
        /// Gets the center.
        /// </summary>
        /// <value>
        /// The center.
        /// </value>
        public double[] Center { get; internal set; }
        /// <summary>
        /// Gets the radius.
        /// </summary>
        /// <value>
        /// The radius.
        /// </value>
        public double Radius { get; internal set; }
        public override Boolean IsNewMemberOf(PolygonalFace face)
        {
            if (Faces.Contains(face)) return false;
            if (Math.Abs(face.Normal.dotProduct(face.Center.subtract(Center)) - 1) >
                Constants.ErrorForFaceInSurface)
                return false;
            foreach (var v in face.Vertices)
                if (Math.Abs(GeometryFunctions.DistancePointToPoint(v.Position, Center) - Radius) > Constants.ErrorForFaceInSurface * Radius)
                    return false;
            return true;
        }

        public override void UpdateWith(PolygonalFace face)
        {
            double[] pointOnLine;
            var distance = GeometryFunctions.DistancePointToLine(Center, face.Center, face.Normal, out pointOnLine);
            var fractionToMove = 1 / Faces.Count;
            var MoveVector = pointOnLine.subtract(Center);
            Center = Center.add(new[] { MoveVector[0] * fractionToMove * distance, MoveVector[1] * fractionToMove * distance, MoveVector[2] * fractionToMove * distance });


            var totalOfRadii = Vertices.Sum(v => GeometryFunctions.DistancePointToPoint(Center, v.Position));
            Radius = totalOfRadii / Vertices.Count;
            base.UpdateWith(face);
        }

    }
}

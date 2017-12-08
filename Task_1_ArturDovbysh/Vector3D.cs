using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_ArturDovbysh
{
    /// <summary>
    /// Represents a 3D vector.
    /// </summary>
    public class Vector3D : IComparable
    {
        /// <summary>
        /// Returns or set X coordinate of the 3D vector.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Returns or set Y coordinate of the 3D vector.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Returns or set Z coordinate of the 3D vector.
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Returns scalar product of two vectors.
        /// </summary>
        /// <param name="v1">First vector.</param>
        /// <param name="v2">Second vector.</param>
        /// <returns></returns>
        public static int ScalarProduct(Vector3D v1, Vector3D v2)
        {
            //a · b = ax · bx + ay · by + az · bz
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        /// <summary>
        /// Returns a new vector as a result of vector product of two vectors.
        /// </summary>
        /// <param name="v1">First vector.</param>
        /// <param name="v2">Second vector.</param>
        /// <returns></returns>
        public static Vector3D VectorProduct(Vector3D v1, Vector3D v2)
        {
            //a × b = { ay*bz - az*by; az*bx - ax*bz; ax*by - ay*bx}
            return new Vector3D(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        /// <summary>
        /// Returns mixed product of three vectors.
        /// </summary>
        /// <param name="v1">First vector.</param>
        /// <param name="v2">Second vector.</param>
        /// <param name="v3">Third vector.</param>
        /// <returns></returns>
        public static int MixedProduct(Vector3D v1, Vector3D v2, Vector3D v3) 
        {
            // a*[b x c] = ax*by*cz + ay*bz*cx + az*bx*cy - (az*by*cx + ay*bx*cz + ax*bz*cy)
            return (v1.X*v2.Y*v3.Z) + (v1.Y*v2.Z*v3.X ) + (v1.Z*v2.X*v3.Y) - (v1.Z*v2.Y*v3.X) - (v1.Y*v2.X*v3.Z) - (v1.X*v2.Z*v3.Y);
        }

        /// <summary>
        /// Returns the angle value between two vectors.
        /// </summary>
        /// <param name="v1">First vector.</param>
        /// <param name="v2">Second vector.</param>
        /// <returns></returns>
        public static double AngleOfVectors(Vector3D v1, Vector3D v2)
        {
            //cos α = ScalarProduct(a,b)/(| a |·| b |)
            return ScalarProduct(v1,v2)/(v1.GetVectorLength()*v2.GetVectorLength());
        }

        /// <summary>
        /// Returns length of the vector.
        /// </summary>
        /// <returns>Vector length.</returns>
        public double GetVectorLength()
        {
            //|a| = sqrt(ax^2 + ay^2 + az^2)
            return Math.Sqrt((int)(X * X) + (int)(Y * Y) + (int)(Z * Z));
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise - false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Vector3D)
            {
                Vector3D vector = (Vector3D)obj;
                return (this.X == vector.X && this.Y == vector.Y && this.Z == vector.Z);
            }
            else return false;
        }

        /// <summary>
        /// Compares this instance to a specified object and returns a value that indicates whether of their relative values.
        /// </summary>
        /// <param name="obj">An object to compare, or a null value.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and parameter value.
        /// Description of the return value:
        /// is less than zero -> than this instance is less than the value;
        /// is zero -> than this instance and value are equal;
        /// is more than zero -> than this instance is greater than value;
        /// or the value is null.
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj is Vector3D)
            {
                if (this.Equals(obj))
                    return 0;

                Vector3D vector = (Vector3D)obj;

                if (this.GetVectorLength() > vector.GetVectorLength())
                    return 1;
                else return -1;
                
            }
            else throw new ArgumentException();

            return 0;
        }

        #region Operators

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="v1">First vector to add.</param>
        /// <param name="v2">Second vector to add.</param>
        /// <returns></returns>
        public static Vector3D operator+(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        /// <summary>
        /// Subtracts two vectors.
        /// </summary>
        /// <param name="v1">First vector to subtract.</param>
        /// <param name="v2">Second vector to subtract.</param>
        /// <returns></returns>
        public static Vector3D operator-(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        /// <summary>
        /// Checks if two vectors are equal.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns></returns>
        public static bool operator==(Vector3D v1, Vector3D v2)
        {
            return v1.Equals(v2);
        }

        /// <summary>
        /// Checks if two vectors are not equal.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns></returns>
        public static bool operator!=(Vector3D v1, Vector3D v2)
        {
            return !v1.Equals(v2);
        }

        /// <summary>
        /// Checks if the first vector is greater than the second.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns></returns>
        public static bool operator>(Vector3D v1, Vector3D v2)
        {
            return v1.CompareTo(v2) > 0;
        }

        /// <summary>
        /// Checks if the first vector is less than the second.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns></returns>
        public static bool operator<(Vector3D v1, Vector3D v2)
        {
            return v1.CompareTo(v2) < 0;
        }

        #endregion

        /// <summary>
        /// Initializes a new vector with coordinates set by default (0,0,0).
        /// </summary>
        public Vector3D(){ }

        /// <summary>
        /// Initializes a new vector with specified coordinates (x,y,z).
        /// </summary>
        /// <param name="x">X coordinate of the vector.</param>
        /// <param name="y">Y coordinate of the vector.</param>
        /// <param name="z">Z coordinate of the vector.</param>
        public Vector3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

    }
}

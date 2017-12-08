using System;

//Реалізувати клас для векторів, що задаються координатами у тривимірному просторі.
//Забезпечити виконання операцій додавання та віднімання векторів з отриманням нового
//вектора, обчислення скалярного, векторного та змішаного добутку двох векторів, довжини
//вектора, кута між векторами, а також порівння двох векторів.

//int MixedProduct -> static


namespace Task_1_ArturDovbysh
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D v1 = new Vector3D(1, 2, 3);
            Vector3D v2 = new Vector3D(3, 2, 1);


            //creation
            Console.WriteLine($"Vector #1 = X: {v1.X} Y: {v1.Y} Z: {v1.Z}");
            Console.WriteLine($"Vector #2 = X: {v2.X} Y: {v2.Y} Z: {v2.Z}");

            //adding and subtracting

            Vector3D v3 = v1 + v2;

            Console.WriteLine($"Vector #1 + Vector #2 = Vector #3 = X: {v3.X} Y: {v3.Y} Z: {v3.Z}");

            Vector3D v4 = v3 - v1;

            Console.WriteLine($"Vector #3 - Vector #1 = Vector #4 = X: {v4.X} Y: {v4.Y} Z: {v4.Z}");

            //comparing

            Console.WriteLine($"Vector #4 = Vector #2 ? -> {v4 == v2}");

            Console.WriteLine($"Vector #4 != Vector #1 ? -> {v3 != v1}");

            //length

            Console.WriteLine($"Vector #1 length = {v1.GetVectorLength()}");
            Console.WriteLine($"Vector #3 length = {v3.GetVectorLength()}");
            Console.WriteLine($"Vector #4 length = {v4.GetVectorLength()}");

            //more comparing

            Console.WriteLine($"Vector #3 > Vector #4 ? -> {v3 > v4}");
            Console.WriteLine($"Vector #3 < Vector #1 ? -> {v4 < v1}");

            //scalar, mixed and vector products

            Console.WriteLine($"Scalar product of Vector #1 and Vector #2 = {Vector3D.ScalarProduct(v1, v2)}");

            Console.WriteLine($"Mixed product of Vector #1 and Vector #2 and Vector#3 = {Vector3D.MixedProduct(v1, v2, v4)}"); //???

            Vector3D v5 = Vector3D.VectorProduct(v1, v2);

            Console.WriteLine($"Vector product of Vector #1 and Vector #2 = Vector #5 = X: {v5.X} Y : {v5.Y} Z : {v5.Z}");

            //angle

            Console.WriteLine($"Angle between Vector #5 and Vector #4 = {Vector3D.AngleOfVectors(v1, v2)}");

            //Delay
            Console.ReadKey();


        }
    }
}

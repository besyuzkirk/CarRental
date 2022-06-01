using CarRental.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarRental.DataAccess
{
    public class RentedCarDal
    {
        DbContext DbContext = new DbContext();
        public void AddRentedCar(RentedCar rentedCar)
        {
            DbContext.ConnectionOpen();
            SqlCommand command = new SqlCommand("INSERT INTO RentedCar(CarId,EndDate,StartDate,TotalDate,TotalRevenue,UserId,Status) VALUES(@CarId,@EndDate,@StartDate,@TotalDate,@TotalRevenue,@UserId,@Status)", DbContext._connection);
            command.Parameters.AddWithValue("@CarId", rentedCar.CarId);
            command.Parameters.AddWithValue("@EndDate", rentedCar.EndDate);
            command.Parameters.AddWithValue("@StartDate", rentedCar.StartDate);
            command.Parameters.AddWithValue("@TotalDate", rentedCar.TotalDay);
            command.Parameters.AddWithValue("@TotalRevenue", rentedCar.TotalRevenue);
            command.Parameters.AddWithValue("@UserId", rentedCar.UserId);
            command.Parameters.AddWithValue("@Status", rentedCar.Status);
            command.ExecuteNonQuery();
            DbContext._connection.Close();
        }

        public List<RentedCar> ListRentedCar()
        {
            DbContext.ConnectionOpen();

            SqlCommand command = new SqlCommand("SELECT * FROM RentedCar WHERE Status = 1 ORDER BY StartDate DESC", DbContext._connection);
            SqlDataReader reader = command.ExecuteReader();

            List<RentedCar> cars = new List<RentedCar>();

            while (reader.Read())
            {
                RentedCar car = new RentedCar
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CarId = Convert.ToInt32(reader["CarId"]),
                    EndDate = Convert.ToDateTime( reader["EndDate"]),
                    StartDate = Convert.ToDateTime(reader["StartDate"]),
                    TotalDay = Convert.ToInt32(reader["TotalDate"]),
                    TotalRevenue = Convert.ToInt32(reader["TotalRevenue"]),
                    UserId = reader["UserId"].ToString()
                };
                
                cars.Add(car);

            }

            if (cars.Count <= 0)
            {
                Console.WriteLine("Error");
            }

            reader.Close();
            DbContext._connection.Close();

            return cars;
        }


        public List<RentedCar> ListAllRents()
        {
            DbContext.ConnectionOpen();

            SqlCommand command = new SqlCommand("SELECT * FROM RentedCar ORDER BY StartDate DESC", DbContext._connection);
            SqlDataReader reader = command.ExecuteReader();

            List<RentedCar> cars = new List<RentedCar>();

            while (reader.Read())
            {
                RentedCar car = new RentedCar
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CarId = Convert.ToInt32(reader["CarId"]),
                    EndDate = Convert.ToDateTime(reader["EndDate"]),
                    StartDate = Convert.ToDateTime(reader["StartDate"]),
                    TotalDay = Convert.ToInt32(reader["TotalDate"]),
                    TotalRevenue = Convert.ToInt32(reader["TotalRevenue"]),
                    UserId = reader["UserId"].ToString()
                };

                cars.Add(car);

            }

            if (cars.Count <= 0)
            {
                Console.WriteLine("Error");
            }

            reader.Close();
            DbContext._connection.Close();

            return cars;
        }

        public void UpdateRendetStatus(int orderId, bool status)
        {
            DbContext.ConnectionOpen();

            SqlCommand command = new SqlCommand("UPDATE RentedCar SET Status=@Status where Id=@id", DbContext._connection);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Id", orderId);
            command.ExecuteNonQuery();

            DbContext._connection.Close();

        }

        public RentedCar GetRentedCar(int id)
        {
            DbContext.ConnectionOpen();

            SqlCommand command = new SqlCommand("SELECT * FROM RentedCar Where Id=@Id", DbContext._connection);
            command.Parameters.AddWithValue("@Id", id);
           
            SqlDataReader reader = command.ExecuteReader();

            List<RentedCar> cars = new List<RentedCar>();

            while (reader.Read())
            {
                RentedCar car = new RentedCar
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CarId = Convert.ToInt32(reader["CarId"]),
                    EndDate = Convert.ToDateTime(reader["EndDate"]),
                    StartDate = Convert.ToDateTime(reader["StartDate"]),
                    TotalDay = Convert.ToInt32(reader["TotalDate"]),
                    TotalRevenue = Convert.ToInt32(reader["TotalRevenue"]),
                    UserId = reader["UserId"].ToString()
                };

                cars.Add(car);

            }

            if (cars.Count <= 0)
            {
                Console.WriteLine("Error");
            }

            reader.Close();
            DbContext._connection.Close();

            return cars[0];
        }
    }


}
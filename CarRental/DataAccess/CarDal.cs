using CarRental.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarRental.DataAccess
{
    public class CarDal
    {
        DbContext DbContext = new DbContext();

        public List<Car> ListCarsWithStatus()
        {
            DbContext.ConnectionOpen();

            SqlCommand command = new SqlCommand("SELECT * FROM Car WHERE Status=1", DbContext._connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Car> cars = new List<Car>();

            while (reader.Read())
            {
                Car car = new Car
                {
                    Id = reader["Id"].ToString(),
                    ImgUrl = reader["ImgUrl"].ToString(),
                    CarName = reader["CarName"].ToString(),
                    ShiftType = reader["ShiftType"].ToString(),
                    Seats = reader["Seats"].ToString(),
                    Luggage = reader["Luggage"].ToString(),
                    AirConditioning = reader["AirConditioning"].ToString(),
                    Price = reader["Price"].ToString()
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

        public List<Car> ListCars()
        {
            DbContext.ConnectionOpen();

            SqlCommand command = new SqlCommand("SELECT * FROM Car", DbContext._connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Car> cars = new List<Car>();

            while (reader.Read())
            {
                Car car = new Car
                {
                    Id = reader["Id"].ToString(),
                    ImgUrl = reader["ImgUrl"].ToString(),
                    CarName = reader["CarName"].ToString(),
                    ShiftType = reader["ShiftType"].ToString(),
                    Seats = reader["Seats"].ToString(),
                    Luggage = reader["Luggage"].ToString(),
                    AirConditioning = reader["AirConditioning"].ToString(),
                    Price = reader["Price"].ToString()
                };

                cars.Add(car);

            }

            if(cars.Count <= 0)
            {
                Console.WriteLine("Error");
            }

            reader.Close();
            DbContext._connection.Close();

            return cars;
        }

        public void AddNewCar(Car car)
        {
            DbContext.ConnectionOpen();
            SqlCommand command = new SqlCommand("INSERT INTO Car(CarName,ShiftType,ImgUrl,Seats,Luggage,AirConditioning,Price,Status) VALUES(@CarName,@ShiftType,@ImgUrl,@Seats,@Luggage,@AirConditioning,@Price,@Status)", DbContext._connection);
            command.Parameters.AddWithValue("@CarName",car.CarName);
            command.Parameters.AddWithValue("@ShiftType", car.ShiftType);
            command.Parameters.AddWithValue("@ImgUrl", car.ImgUrl);
            command.Parameters.AddWithValue("@Seats", car.Seats);
            command.Parameters.AddWithValue("@Luggage", car.Luggage);
            command.Parameters.AddWithValue("@AirConditioning", car.AirConditioning);
            command.Parameters.AddWithValue("@Price", car.Price);
            command.Parameters.AddWithValue("@Status", car.Status);
            command.ExecuteNonQuery();
            DbContext._connection.Close();

        }

        public Car GetCar(int id)
        {
            DbContext.ConnectionOpen();
            SqlCommand command = new SqlCommand("SELECT * FROM Car WHERE Id=@id", DbContext._connection);
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            List<Car> cars = new List<Car>();

            while (reader.Read())
            {
                Car car = new Car
                {
                    Id = reader["Id"].ToString(),
                    ImgUrl = reader["ImgUrl"].ToString(),
                    CarName = reader["CarName"].ToString(),
                    ShiftType = reader["ShiftType"].ToString(),
                    Seats = reader["Seats"].ToString(),
                    Luggage = reader["Luggage"].ToString(),
                    AirConditioning = reader["AirConditioning"].ToString(),
                    Price = reader["Price"].ToString()
                };

                cars.Add(car);
            }
            DbContext._connection.Close();
            return cars[0];
            

        }

        public void UpdateCarStatus(int carId, bool status)
        {
            DbContext.ConnectionOpen();

            SqlCommand command = new SqlCommand("UPDATE Car SET Status=@Status where Id=@id", DbContext._connection);
            command.Parameters.AddWithValue("@Status", status );
            command.Parameters.AddWithValue("@Id", carId);
            command.ExecuteNonQuery();

            DbContext._connection.Close();

        }

        public void UpdateCar(int id , Car car)
        {
            DbContext.ConnectionOpen();
            SqlCommand command = new SqlCommand("Update Car SET CarName = @CarName,ShiftType = @ShiftType,ImgUrl = @ImgUrl,Seats = @Seats,Luggage = @Luggage,AirConditioning = @AirConditioning,Price = @Price Where Id=@Id", DbContext._connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@CarName", car.CarName);
            command.Parameters.AddWithValue("@ShiftType", car.ShiftType);
            command.Parameters.AddWithValue("@ImgUrl", car.ImgUrl);
            command.Parameters.AddWithValue("@Seats", car.Seats);
            command.Parameters.AddWithValue("@Luggage", car.Luggage);
            command.Parameters.AddWithValue("@AirConditioning", car.AirConditioning);
            command.Parameters.AddWithValue("@Price", car.Price);
            command.Parameters.AddWithValue("@Status", car.Status);
            command.ExecuteNonQuery();
            DbContext._connection.Close();

        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment3.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }

        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> GetAllMovies()
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> GetMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> DeleteMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM movie WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> InsertMovie(MovieItem movie)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO movie(Name,Genre,Duration,ReleaseDate) VALUES('" + movie.Name + "','"+ movie.Genre + "','" + movie.Duration + "','" + movie.ReleaseDate +"')", conn);
                // cmd.Parameters.AddWithValue("@name", name);
                // cmd.Parameters.AddWithValue("@genre", genre);
                // cmd.Parameters.AddWithValue("@duration", duration);
                // cmd.Parameters.AddWithValue("@releasedate", releasedate);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> UpdateMovie(string id, MovieItem movie)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE movie SET Name='" + movie.Name 
                +"', Genre='" + movie.Genre 
                + "', Duration='" + movie.Duration 
                + "', ReleaseDate='" + movie.ReleaseDate 
                + "' WHERE Id=" + id, conn);
                // cmd.Parameters.AddWithValue("@name", name);
                // cmd.Parameters.AddWithValue("@genre", genre);
                // cmd.Parameters.AddWithValue("@duration", duration);
                // cmd.Parameters.AddWithValue("@releasedate", releasedate);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

    }
}

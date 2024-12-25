using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formui {
    internal class User {
        /**
         * Properties;
         */
        private string Token;
        private string ID;

        public string Username;
        public string Email;
        public string Role;
        public bool IsLoggedIn;

        private Network network = new Network("http://vps.omerfarukaras.online:5000", null);

        /**
         * User;
         */
        public User() {

        }

        /**
         * Public fonksiyonlar;
         */
        public async Task Load() {
            try {
                dynamic resp = await network.CheckToken();
                if (String.IsNullOrEmpty(resp.data.id)) {
                    IsLoggedIn = true;
                    Token = Registery.LoadToken();
                    ID = resp.data["id"];
                    Username = resp.data["username"];
                    Email = resp.data["email"];
                    Role = resp.data["role"];
                }
            } catch (Exception e) {
                Registery.DeleteToken();
                Console.WriteLine(e.Message);
                IsLoggedIn = false;
            }
        }

        public async Task<(bool, string?)> Login(string username, string password) {
            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password)) {
                var resp = await network.Login(username, password);
                if (resp.haveError != "true") {
                    Registery.SaveToken((string)resp.data.token);
                    return (true, null);
                } else {
                    return (false, resp.error);
                };
            } else return (false, "Kullanıcı adı ve ya Şifre yanlış.");
        }
        public async Task<(bool, string?)> Register(string username, string password, string email) {
            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password) && !String.IsNullOrEmpty(email)) {
                var resp = await network.Register(username, password, email);
                if (resp.haveError != "true") {
                    Registery.SaveToken((string)resp.data.token);
                    return (true, null);
                } else {
                    return (false, resp.error);
                };
            } else return (false, "Girişleri gözden geçirin.");
        }
        public bool CheckSavedUser() {
            string? token = Registery.LoadToken();
            if (!String.IsNullOrEmpty(token)) {
                Token = token;
                return true;
            } else return false;
        }

        /**
         * Private fonksiyonlar;
         */
    }
}

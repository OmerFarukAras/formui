using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Text.Json;


namespace formui {
    internal class Registery {
        private static readonly string TokenFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DocAI", "token.txt");

        public static void SaveToken(string token) {
            string? directory = Path.GetDirectoryName(TokenFilePath);
            if (!String.IsNullOrEmpty(directory) && !Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
            }
            File.WriteAllText(TokenFilePath, token);
        }

        public static string? LoadToken() {
            if (File.Exists(TokenFilePath)) {
                return File.ReadAllText(TokenFilePath);
            }
            return null;
        }

        public static bool CheckToken() {
            string? token = Registery.LoadToken();
            if (!String.IsNullOrEmpty(token)) {
                return true;
            } else return false;
        }

        public static void DeleteToken() {
            if (File.Exists(TokenFilePath)) {
                File.Delete(TokenFilePath);
            }
        }
    }
}

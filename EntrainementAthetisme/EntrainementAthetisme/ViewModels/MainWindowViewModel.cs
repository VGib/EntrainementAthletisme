using EntrainementAthletisme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using MessageBox.Avalonia;
using MessageBox.Avalonia.DTO;
using System.Threading.Tasks;

namespace EntrainementAthetisme.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public AthleteStatistiques Statistique { get; private set; }

        public readonly string ConfigDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EntrainementAthletisme");
        public string ConfigFile;

        public IEnumerable<NiveauEntrainementLabel> TypeDEntrainements { get; } = new List<NiveauEntrainementLabel>
        {
           new NiveauEntrainementLabel
           {
               Name = "E/L",

               MinPourcentageDeLaFrequenceCardiaqueMax = 65,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 79,
           },
            new NiveauEntrainementLabel
           {
               Name = "M",

               MinPourcentageDeLaFrequenceCardiaqueMax = 80,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 89,
           },
             new NiveauEntrainementLabel
           {
               Name = "T",
               MinPourcentageDeLaFrequenceCardiaqueMax = 88,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 92,
           },
                new NiveauEntrainementLabel
           {
               Name = "10 km",
               MinPourcentageDeLaFrequenceCardiaqueMax = 92.5,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 97,
           },
            new NiveauEntrainementLabel
           {
               Name = "I",
               MinPourcentageDeLaFrequenceCardiaqueMax = 97.5,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 100,
           }
        };

        public IEnumerable<NiveauEntrainementLabel> AllureCompetition { get; } = new List<NiveauEntrainementLabel>
        {
             new NiveauEntrainementLabel
           {
               Name = "Marathon",
               MinPourcentageDeLaFrequenceCardiaqueMax = 75,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 85
             },
             new NiveauEntrainementLabel
           {
               Name = "Semi-marathon",
               MinPourcentageDeLaFrequenceCardiaqueMax = 85,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 90
             },
             new NiveauEntrainementLabel
           {
               Name = "10 km",
               MinPourcentageDeLaFrequenceCardiaqueMax = 90,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 94
             }
        };

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MainWindowViewModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            LoadStatistiques();
#pragma warning disable CS8604 // Possible null reference argument.
            NiveauxDEntrainements = TypeDEntrainements.Select(x => new NiveauEntrainement(x, Statistique)).ToArray();
            NiveauxCompetition = AllureCompetition.Select(x => new NiveauEntrainement(x, Statistique)).ToArray();
#pragma warning restore CS8604 // Possible null reference argument.
        }

        private void LoadStatistiques()
        {
            try
            {
                if (!Directory.Exists(ConfigDirectory))
                {
                    Directory.CreateDirectory(ConfigDirectory);
                }

                ConfigFile = Path.Combine(ConfigDirectory, "statistique.json");

                if (!File.Exists(ConfigFile))
                {
                    Statistique = new AthleteStatistiques
                    {
                        FrequenceCardiaqueMin = 43,
                        FrequenceCardiaqueMax = 184
                    };

                    var jsonText = JsonSerializer.Serialize(Statistique);
                    File.WriteAllText(ConfigFile, jsonText);
                }
                else
                {
                    var jsonText = File.ReadAllText(ConfigFile);
                    Statistique = JsonSerializer.Deserialize<AthleteStatistiques>(jsonText) ?? new AthleteStatistiques();
                }
            }
            catch (Exception)
            {
                Statistique = new AthleteStatistiques
                {
                    FrequenceCardiaqueMin = 43,
                    FrequenceCardiaqueMax = 184
                };

                Task.Factory.StartNew(() =>
                {
                    var messageBox = MessageBoxManager.GetMessageBoxStandardWindow(
                        new MessageBoxStandardParams()
                        {
                            ContentTitle = "Une erreur est survenue",
                            ContentMessage = $"Vérifiez le fichier de Configuration à l'addresse suivante {ConfigFile}",
                            Icon = MessageBox.Avalonia.Enums.Icon.Error,
                            WindowStartupLocation = Avalonia.Controls.WindowStartupLocation.CenterScreen,
                            ButtonDefinitions = MessageBox.Avalonia.Enums.ButtonEnum.Ok,
                            ShowInCenter = true
                        }
                        );
                    messageBox.ShowDialog(App.MainWindow);
                },new System.Threading.CancellationToken(), TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        public IEnumerable<NiveauEntrainement> NiveauxDEntrainements { get; }

        public IEnumerable<NiveauEntrainement> NiveauxCompetition { get; }

        public string EditMessage => $"vous pouvez editez vos statistiques: {ConfigFile}";
    }
}

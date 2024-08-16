using DALL_E.Models;
using System.Collections.ObjectModel;

namespace DALL_E.Views;

public partial class DashBoardview : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImages> GeneratedImages	{ get; set; }
	public DashBoardview()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}

    

    private void LoadData()
	{
        Profiles = new ObservableCollection<Profile>
        {
            new Profile
            {
                Name = "Hector",
                ProfileImage = "fotohector.jpg",
                NoPhotos = 12
            },
            new Profile
            {
                Name = "Mady",
                ProfileImage = "fotomady.jpg",
                NoPhotos = 5
            },
            new Profile
            {
                Name = "Henry",
                ProfileImage = "fotohenry.jpg",
                NoPhotos = 20
            }


        };
        GeneratedImages = new ObservableCollection<GeneratedImages>
        {
            new GeneratedImages
            {
                ImagePath = "hectorgenero.jpg",
                MainKeyword = "Mountains",
                Keywords = new List<string>{"Landscape, photorealistic, dawn, mountains"}
            },
            new GeneratedImages
            {
                ImagePath = "madygenero.jfif",
                MainKeyword = "Robot",
                Keywords = new List<string>{"AI, robotic, human, ligth, metal"}
            },
            new GeneratedImages
            {
                ImagePath = "henrygenero.jfif",
                MainKeyword = "Castle",
                Keywords = new List<string>{"Epic, hill, mountain, tress, blue sky"}
            }
        };
	}
}
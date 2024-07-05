# Customize-MAUI-Avatar-View

The .NET MAUI Avatar View control enhances the user experience by enabling the creation of highly customizable user profile images within applications. This feature supports a variety of customization options, including adding images, background colors, icons, and text. This capability not only enhances the visual appeal of the application but also allows for a more engaging and customizable user interface, contributing to a richer user experience.

This sample demonstrates how to add predefined Avatar characters, display initials and images in Avatar View. You’ll also see how to add images to the group view, apply visual styles, and customize the avatar view by changing its background color and size.

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## How to run the sample

1. Clone the sample and open it in Visual Studio 2022.
   
   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
		
			InitializeComponent();
		
			MainPage = new MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/maui/licensing/overview) for more details.
	
3. Clean and build the application.

4. Run the application.

## Sample

```xaml
<StackLayout HorizontalOptions="Center" VerticalOptions="Center">
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="100*"/>
            <ColumnDefinition Width="400*"/>
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <sfavatar:SfAvatarView ContentType="Group" GroupSource="{Binding ProfileCollection}" 
               ImageSourceMemberPath="ImageSource" Grid.Column="0" Grid.Row="0" 
               Margin="20,30,0,30" WidthRequest="100" HeightRequest="100" CornerRadius="50"/>
        <Label Text="Sales Managers" FontAttributes="Bold" Grid.Column="1" HorizontalTextAlignment="Start" 
               VerticalTextAlignment="Center" Padding="40,0,0,0" Grid.Row="0" FontSize="20"/>

        <sfavatar:SfAvatarView ContentType="Group" GroupSource="{Binding ProfileCollection}" 
               InitialsMemberPath="Name" Grid.Column="0" Grid.Row="1" AvatarColorMode="LightBackground" 
               Margin="20,30,0,30" WidthRequest="100" HeightRequest="100" CornerRadius="50"/>
        <Label Text="Marketing Managers" FontAttributes="Bold" Grid.Column="1" HorizontalTextAlignment="Start"
               VerticalTextAlignment="Center" Padding="40,0,0,0" Grid.Row="1" FontSize="20"/>

        <sfavatar:SfAvatarView ContentType="Custom" ImageSource="ella.png" Grid.Column="0" Grid.Row="2" 
               Margin="20,30,0,30" WidthRequest="100" HeightRequest="100" CornerRadius="50"/>
        <Label Text="Ella Morris" FontAttributes="Bold" Grid.Column="1" HorizontalTextAlignment="Start"
               VerticalTextAlignment="Center" Padding="40,0,0,0" Grid.Row="2" FontSize="20"/>

        <sfavatar:SfAvatarView ContentType="Custom" ImageSource="mia.png" Grid.Column="0" Grid.Row="3" 
               Margin="20,30,0,30" WidthRequest="100" HeightRequest="100" CornerRadius="50"/>
        <Label Text="Mia George" FontAttributes="Bold" Grid.Column="1" HorizontalTextAlignment="Start"
               VerticalTextAlignment="Center" Padding="40,0,0,0" Grid.Row="3" FontSize="20"/>

        <sfavatar:SfAvatarView ContentType="Custom" ImageSource="alex.png" Grid.Column="0" Grid.Row="4"
               Margin="20,30,0,30" WidthRequest="100" HeightRequest="100" CornerRadius="50"/>
        <Label Text="Alex" FontAttributes="Bold" Grid.Column="1" HorizontalTextAlignment="Start"
               VerticalTextAlignment="Center" Padding="40,0,0,0" Grid.Row="4" FontSize="20"/>

    </Grid>
</StackLayout>
```

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
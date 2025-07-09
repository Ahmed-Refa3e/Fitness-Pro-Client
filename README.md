# Fitness Pro Client

The Fitness Pro Client is the frontend application designed to interact with the Fitness Pro backend. It provides a user-friendly interface for managing gym-related activities, including viewing gym branches, trainers, classes, and online training programs. This client application is built to deliver a seamless and efficient user experience.

## Key Features
- **User Interface**: Intuitive and responsive design for easy navigation and interaction.
- **Data Display**: Effectively displays data fetched from the Fitness Pro backend, such as gym details, trainer profiles, class schedules, and subscription information.
- **Authentication**: Handles user authentication and authorization, securely storing JWT tokens for API communication.
- **Payment Integration**: Facilitates secure payment processing through integration with the backend's Stripe API.
- **Image Display**: Displays images and files securely stored in Azure Blob Storage, such as gym logos and trainer photos.

## Technologies Used
- **Blazor**: Frontend built with Blazor, leveraging C# for client-side web development.
- **HTML/CSS**: Standard web technologies for structuring and styling the user interface.
- **JavaScript**: Used for client-side interactivity and integration with various libraries.
- **JWT Authentication**: Secure token-based authentication for API requests.

## Installation and Setup
1. Clone the repository:
    ```bash
    git clone https://github.com/Ahmed-Refa3e/Fitness-Pro-Client.git
    ```
2. Navigate to the project directory:
    ```bash
    cd Fitness-Pro-Client
    ```
3. Restore .NET dependencies:
    ```bash
    dotnet restore
    ```
4. Run the application:
    ```bash
    dotnet run
    ```

## Usage
- After running the application, open your web browser and navigate to the local host address (e.g., `https://localhost:5001` or `http://localhost:5000`).
- Interact with the user interface to browse gyms, trainers, classes, and manage your profile.
- Ensure the Fitness Pro backend is running and accessible for full functionality.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgements
Special thanks to the open-source community for providing the tools and frameworks used in this project.

---

<div align="left">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="40" alt="csharp logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg" height="40" alt="html5 logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/css3/css3-original.svg" height="40" alt="css3 logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/blazor/blazor-original.svg" height="40" alt="blazor logo"  />
  <img width="12" />
</div>



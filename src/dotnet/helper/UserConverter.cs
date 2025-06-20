using dotnet.DAL;
using dotnet.DTOs;
using dotnet.Models;

namespace dotnet.Helper
{
    public static class UserConverter
    {
        // Convert from User to UserDAL (Database Model)
        public static UserDAL FromUserToUserDAL(User user)
        {
            return new UserDAL
            {
                UserID = user.Id,  // Assuming `Id` is the primary key in `User`
                UDID = user.Udid,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Age = user.Age ?? 0,
                Gender = user.Gender,
                Height = user.Height ?? 0.0,
                Weight = user.Weight ?? 0.0,
                BodyFat = user.BodyFat ?? 0.0,
                Goal = user.Goal,
                PhoneNum = user.PhoneNum,
                Username = user.Username,
                PasswordHash = user.PasswordHash,
                PasswordSalt = user.PasswordSalt,
                ProfilePhotoPath = user.ProfilePhotoPath
            };
        }

        // Convert from UserDAL (Database Model) to User
        public static User FromUserDALToUser(UserDAL userDAL)
        {
            return new User
            {
                Id = userDAL.UserID,
                Udid = userDAL.UDID,
                FirstName = userDAL.FirstName,
                LastName = userDAL.LastName,
                Email = userDAL.Email,
                Age = userDAL.Age,
                Gender = userDAL.Gender,
                Height = userDAL.Height,
                Weight = userDAL.Weight,
                BodyFat = userDAL.BodyFat,
                Goal = userDAL.Goal,
                PhoneNum = userDAL.PhoneNum,
                Username = userDAL.Username,
                PasswordHash = userDAL.PasswordHash,
                PasswordSalt = userDAL.PasswordSalt,
                ProfilePhotoPath = userDAL.ProfilePhotoPath
            };
        }

        // Convert from User to UserDTO (Frontend Model)
        public static UserDTO FromUserToUserDTO(User user)
        {
            return new UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Age = user.Age,
                Gender = user.Gender,
                Height = user.Height,
                Weight = user.Weight,
                BodyFat = user.BodyFat,
                Goal = user.Goal,
                PhoneNum = user.PhoneNum,
                Username = user.Username,
                ProfilePhotoPath = user.ProfilePhotoPath
            };
        }

        // Convert from UserDTO (Frontend Model) to User
        public static User FromUserDTOToUser(UserDTO userDTO, int id = 0, int udid = 0)
        {
            return new User
            {
                Id = id, // Set only if provided
                Udid = udid, // Set only if provided
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email,
                Age = userDTO.Age,
                Gender = userDTO.Gender,
                Height = userDTO.Height,
                Weight = userDTO.Weight,
                BodyFat = userDTO.BodyFat,
                Goal = userDTO.Goal,
                PhoneNum = userDTO.PhoneNum,
                Username = userDTO.Username,
                ProfilePhotoPath = userDTO.ProfilePhotoPath
            };
        }
    }
}

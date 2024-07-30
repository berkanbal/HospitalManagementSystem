using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Database
{
    public class HospitalDbContext : DbContext
    {
        //public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        Helper.Helper helper;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");

        }
        public Patient PatientIDValidation(string ID)
        {
            return Patients.SingleOrDefault(p => p.identification == ID);
        }
        public Doctor DoctorIDValidation(string ID)
        {
            return Doctors.SingleOrDefault(p => p.identification == ID);
        }
        public Secretary SecretaryIDValidation(string ID)
        {
            return Secretaries.SingleOrDefault(p => p.identification == ID);
        }
        public Admin AdminIDValidation(string ID)
        {
            return Admins.SingleOrDefault(p => p.identification == ID);
        }
        public Appointment AppointmentIDValidation(int ID)
        {
            return Appointments.SingleOrDefault(p => p.AppointmentId == ID);
        }
        public void deleteSecretaryByID(int id)
        {
            var entityToDelete = Secretaries.FirstOrDefault(entity => entity.SecretaryId == id);

            if (entityToDelete != null)
            {
                Secretaries.Remove(entityToDelete);
                SaveChanges();
                MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID not found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void deleteDoctorByID(int id)
        {
            var entityToDelete = Doctors.FirstOrDefault(entity => entity.DoctorId == id);

            if (entityToDelete != null)
            {
                Doctors.Remove(entityToDelete);
                SaveChanges();
                MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID not found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updateSecretaryByID(int id,string newName, string newSurname, string newIdentificationNo, string newGSMNo)
        {
            var entityToUpdate = Secretaries.FirstOrDefault(entity => entity.SecretaryId == id);

            if (entityToUpdate != null)
            {
                entityToUpdate.name = newName;
                entityToUpdate.surname = newSurname;
                entityToUpdate.identification = newIdentificationNo;
                entityToUpdate.GSM_No = newGSMNo;

                SaveChanges();

                MessageBox.Show("Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Guncelleme islemi yapilamadi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updatePatientByID(int id, string newName, string newSurname, string newIdentificationNo, string newGSMNo)
        {
            var entityToUpdate = Patients.FirstOrDefault(entity => entity.PatientId == id);

            if (entityToUpdate != null)
            {
                entityToUpdate.name = newName;
                entityToUpdate.surname = newSurname;
                entityToUpdate.identification = newIdentificationNo;
                entityToUpdate.GSM_No = newGSMNo;

                SaveChanges();

                MessageBox.Show("Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Guncelleme islemi yapilamadi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updateSecretaryPasswordByID(int id, string oldPassword, string newPassword, string newAgainPassword, string password)
        {
            var entityToUpdate = Secretaries.FirstOrDefault(entity => entity.SecretaryId == id);

            Helper.PasswordHasher hasher = new Helper.PasswordHasher();
            string hashedPassword = hasher.HashPassword(password);

            if (hashedPassword != null)
            {
                if (hasher.VerifyPassword(oldPassword, password))
                {
                    if (newPassword == newAgainPassword)
                    {
                        entityToUpdate.password = hasher.HashPassword(newPassword);
                        SaveChanges();
                        MessageBox.Show("Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Guncelleme islemi yapilamadi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updateDoctorPasswordByID(int id, string oldPassword, string newPassword, string newAgainPassword, string password)
        {
            var entityToUpdate = Doctors.FirstOrDefault(entity => entity.DoctorId == id);

            Helper.PasswordHasher hasher = new Helper.PasswordHasher();
            string hashedPassword = hasher.HashPassword(password);

            if (hashedPassword != null)
            {
                if (hasher.VerifyPassword(oldPassword, password))
                {
                    if (newPassword == newAgainPassword)
                    {
                        entityToUpdate.password = hasher.HashPassword(newPassword);
                        SaveChanges();
                        MessageBox.Show("Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Guncelleme islemi yapilamadi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updatePatientPasswordByID(int id, string oldPassword, string newPassword, string newAgainPassword, string password)
        {
            var entityToUpdate = Patients.FirstOrDefault(entity => entity.PatientId == id);
            
            Helper.PasswordHasher hasher = new Helper.PasswordHasher();
            string hashedPassword = hasher.HashPassword(password);

            if (hashedPassword != null)
            {
                if (hasher.VerifyPassword(oldPassword,password))
                {
                    if (string.Equals(newPassword,newAgainPassword))
                    {
                        entityToUpdate.password = hasher.HashPassword(newPassword);
                        SaveChanges();
                        MessageBox.Show("Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Guncelleme islemi yapilamadi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updateDoctorByID(int id, string newName, string newSurname, string newIdentificationNo, string newGSMNo,string newBranch)
        {
            var entityToUpdate = Doctors.FirstOrDefault(entity => entity.DoctorId == id);

            if (entityToUpdate != null)
            {
                entityToUpdate.name = newName;
                entityToUpdate.surname = newSurname;
                entityToUpdate.identification = newIdentificationNo;
                entityToUpdate.GSM_No = newGSMNo;
                entityToUpdate.branch = newBranch;

                SaveChanges();

                MessageBox.Show("Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Guncelleme islemi yapilamadi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updateDoctorByID(int id, string newName, string newSurname, string newIdentificationNo, string newGSMNo)
        {
            var entityToUpdate = Doctors.FirstOrDefault(entity => entity.DoctorId == id);

            if (entityToUpdate != null)
            {
                entityToUpdate.name = newName;
                entityToUpdate.surname = newSurname;
                entityToUpdate.identification = newIdentificationNo;
                entityToUpdate.GSM_No = newGSMNo;

                SaveChanges();

                MessageBox.Show("Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Guncelleme islemi yapilamadi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

﻿using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepo;
        public StudentService()
        {
            _studentRepo = new StudentRepository();
        }
        public void Create(Student student)
        {
            _studentRepo.Create(student);
        }

        public void Delete(Student student)
        {
            _studentRepo.Delete(student);
        }

        public void Edit(Student student)
        {
            // throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return _studentRepo.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentRepo.GetById(id);
        }

        public Student Search(string fullName)
        {
            return _studentRepo.Search(fullName);
        }

        public List<Student> Sort(int age)
        {
            return _studentRepo.Sort(age);
        }
    }
}

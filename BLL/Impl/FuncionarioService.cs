﻿using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Funcionarios;
using Shared;
using DataAccessLayer.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Impl
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioDAO _funcionarioDAO;
        private readonly ITokenService tokenService;
        public FuncionarioService(IFuncionarioDAO funcionarioDAO, ITokenService tokenService)
        {
            _funcionarioDAO = funcionarioDAO;
            this.tokenService = tokenService;
        }
        public async Task<Response> Insert(Funcionario funcionario)
        {
            Response response = new FuncInsertValidator().Validate(funcionario).ConvertToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            response = await _funcionarioDAO.Insert(funcionario);
            return response;
        }

        public async Task<Response> Update(Funcionario funcionario)
        {
            Response response = new FuncInsertValidator().Validate(funcionario).ConvertToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
   
            return await _funcionarioDAO.Update(funcionario); 
        }
        public async Task<Response> Delete(Funcionario funcionario)
        {
            Response response = new FuncInsertValidator().Validate(funcionario).ConvertToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            response = await _funcionarioDAO.Delete(funcionario);
            return response;
        }

        public async Task<DataResponse<Funcionario>> GetAll()
        {
            return await _funcionarioDAO.GetAll();
        }

        public async Task<SingleResponse<Funcionario>> GetById(int id)
        {
            return await _funcionarioDAO.GetById(id);
        }

        public async Task<SingleResponse<Funcionario>> GetLogin(Funcionario funcionario)
        {
            return await _funcionarioDAO.GetLogin(funcionario);
        }

        public async Task<SingleResponse<Funcionario>> GetByEmail(Funcionario funcionario)
        {
            return await _funcionarioDAO.GetByEmail(funcionario);
        }
    }
}

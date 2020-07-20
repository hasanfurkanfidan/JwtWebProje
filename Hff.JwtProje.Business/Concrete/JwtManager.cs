using Hff.JwtProje.Business.Interfaces;
using Hff.JwtProje.Business.StringInfos;
using Hff.JwtProje.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Hff.JwtProje.Business.Concrete
{
   public class JwtManager:IJwtService
    {
        public string CreateJwtToken(AppUser appUser,List<AppRole>roles)
        {
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtInfos.SecurityKey));
            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256); 
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer:JwtInfos.Issuer,audience:JwtInfos.Audience,notBefore:DateTime.Now,expires:DateTime.Now.AddSeconds(JwtInfos.Expires),signingCredentials:credentials,claims:GetClaims(appUser,roles)); 
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return  handler.WriteToken(jwtSecurityToken);
        }
        private List<Claim> GetClaims(AppUser appUser, List<AppRole> roles)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name , appUser.UserName));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, appUser.Id.ToString()));
            if (roles.Count > 0)
            {
                foreach(var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Name));
                }
            }
            return null;
        }
    }
}

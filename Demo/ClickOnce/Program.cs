using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClickOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            static void CreateDeployment(string name)
            {
                //2: create version folde
                _publishDir = Path.Combine(_publishRootDir, name);
                var versionPath = Path.Combine(_publishDir, _version);
                Directory.CreateDirectory(versionPath);

                Thread.Sleep(100);
//1Ba.copy iles from source to version Folder
foreach(var file in Directory.GetFiles(_sourceDir))
                {
                    var ext = Path.GetExtension(file.ToLower());

if(ext  == ".dll" || ext==".exe" || ext=".config")
                    {                                                                                                                          
Var fileN.me Path.GelileName(tile)
r drsttPath Path.Combine(versionPath, ileNue)
File.lopy(File, destPath
if (des tPalh.CndsWil h

/ wE need to sel the corect host tor each environment
I / var contonts2 le ReudAirexe(destPath):
        }
    }
}

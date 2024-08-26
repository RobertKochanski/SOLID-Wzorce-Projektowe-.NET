using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ScanFacade
    {
        private QualityScanner qualityScanner = new QualityScanner();
        private SecurityScanner securityScanner = new SecurityScanner();
        private DependencyScanner dependencyScanner = new DependencyScanner();
        private ReportGenerator reportGenerator = new ReportGenerator();

        public void Scan(string gitHubUrl)
        {
            Console.WriteLine($"Scanning {gitHubUrl}");

            var qualityScannerErrors = qualityScanner.QualityScan(gitHubUrl);
            var securityScannerErrors = securityScanner.SecurityScan(gitHubUrl);
            var dependencyScannerErrors = dependencyScanner.DependencyScan(gitHubUrl);

            Console.WriteLine("Scan report");
            reportGenerator.GenerateReport(qualityScannerErrors, securityScannerErrors, dependencyScannerErrors);
        }
    }
}

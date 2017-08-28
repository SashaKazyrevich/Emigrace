$projectName='EMI'
$log = git log --merges --oneline --decorate 
$split = $log -split "`n"
$pattern = "\/(\w+)\/(\w+\-\d+)"
$result = ""
$features = New-Object 'System.Collections.Generic.HashSet[string]'
$hotfixes = New-Object 'System.Collections.Generic.HashSet[string]'
$bugfixes = New-Object 'System.Collections.Generic.HashSet[string]'

for($i=$split.Length-1; $i -ge 0; $i--)
{
  if (-not ($split[$i] -match $pattern))
  {
    continue;
  }
  
  switch ($matches[1])
  {
    'feature' {$features.Add($matches[2])}
    'bugfix' {$bugfixes.Add($matches[2])}
    'hotfix' {$hotfixes.Add($matches[2])}
  }


}




#1. split $log by lines
#2. go from bottom
#     for each line, 
#       find "/feature/", "/bugfix/", "/hotfix/"  (use list variable) 
#       extract <project name>-<number>  
#     if line has tag 
#       generate changelog for tag release
#             <tag>
#             Features: {list}  
#             Bug fixes: {list}
#             Hotfixes: {list}  
#             (if no features or not bugfixes etc, do not display the section)   
# Usage
Personal access token is required to authorize, use `-t` or `--token` flag

Specify the list or repositories you'd like to work with, use `-n` or `--names` flag

> Names are separated by comma, wrap the parameter in double-quotes if you want space characters in your repository's name
```
$ repomanager.exe --token <your_token> --names foo,bar
```

You can delete the given repositories by using `-d` or `--delete` flag
```
$ repomanager.exe -t <your_token> -n "foo bar,bar foo" -d
```

Same documentation and some minor info could be found under `--help` flag

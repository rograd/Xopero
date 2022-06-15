# Usage
Personal access token is required to authorize, use `--token` flag

> Your token has to have `public_repo` scope in order to create repositories
> 
> And `delete_repo` scope in order to delete repositories

# Creating repositories

## Creating custom repositories
Use `create` verb
```
$ RepoManager.exe create foo bar any other names --token <your_token>
```

## Creating repositories recursively
Use `recursive` verb

Specify the number of repositories to create that way, use `--times` flag
```
$ RepoManager.exe recursive foobar --times 20 --token <your_token>
```
> The above will result in creating foobar1, foobar2... foobar20

# Deleting repositories
Use `delete` verb
```
$ RepoManager.exe delete --token <your_token>
```
> The program will prompt you a notepad with list of currently existing repositories, **leave** those you want to be removed

###### Some more could be found under `help` verb

---
title: "启动本地服务器"
description: "启动本地Counter-Strike服务器"
lead: "启动本地Counter-Strike服务器"
date: 2023-04-22T13:26:54+01:00
lastmod: 2023-04-22T13:26:54+01:00
draft: false
images: []
menu:
  docs:
    parent: "help"
weight: 610
toc: true
---

## Check for outdated packages

The [`npm outdated`](https://docs.npmjs.com/cli/v7/commands/npm-outdated) command will check the registry to see if any (or, specific) installed packages are currently outdated:

```bash
npm outdated [[<@scope>/]<pkg> ...]
```

## Update packages

The [`npm update`](https://docs.npmjs.com/cli/v7/commands/npm-update) command will update all the packages listed to the latest version (specified by the tag config), respecting semver:

```bash
npm update [<pkg>...]
```

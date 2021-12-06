A free, open-source tool for generating random user data. Like Lorem Ipsum, but for people.

# Installation
Clone project:
```
git clone https://github.com/rlyonheart/rug.git
```

```
cd rug
```

```
pip install -r requirements.txt
```

# Usage
```
python rug
```

Or 
```
chmod +x rug
```

```
./rug
```

> **Note**: use flag *-v* to initiate **verbose** mode, showing network *logs*, *errors*, and *notices*.

# Arguments
| Flag          |MetaVar|                 Usage|
| ------------- |:----------------------:|:---------:|
| <code>-r/--results</code>      |   **[NUMBER]** |  *results count (default is 10)*  |
| <code>-n/--nationality</code>  |  **[NATIONALIT(Y)(IES)]**  |  *specify nationalit(y)(ies). If more than one, they ahould be seperated by a coma(es, gb, af, us, eu). Default takes all available nationalities*  |
| <code>-v/--verbose</code>  |    |  *[RECOMMENDED] run rug in verbose mode (show network logs, errors, and notices)*  |

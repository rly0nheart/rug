import os
import sys
import logging
import random
import requests
import argparse
from datetime import datetime
sys.path.append(os.getcwd()+"/.lib/")
from headers import user_agents
from colors import red, white, green, reset

    
class User:
	def __init__(self, args):
		self.headers = {"User-Agent": f"{random.choice(user_agents)}"}
		self.api = f"https://randomuser.me/api/?results={args.results}&nat={args.nationality}"
		self.response = requests.get(self.api, headers=self.headers).json()
		
	def on_connection(self):
		for data in self.response['results']:
		    info = {"Title": data['name']['title'],
		                "Sex": data['gender'],
		                "Age": data['dob']['age'],
		                "Date of birth": data['dob']['date'],
		                "Nationality": data['nat'],
		                "Country": data['location']['country'],
		                "City": data['location']['city'],
		                "State": data['location']['state'],
		                "Postcode": data['location']['postcode'],
		                "Street No": data['location']['street']['number'],
		                "Street name": data['location']['street']['name'],
		                f"Co-ordinates\nLatitude: {green}{data['location']['coordinates']['latitude']}{white}\nLongitude": data['location']['coordinates']['longitude'],
		                f"Timezone\n{white}Offset: {green}{data['location']['timezone']['offset']}{white}\nDescription": data['location']['timezone']['description'],
		                "Phone": data['phone'],
		                "Cell": data['cell'],
		                "Email": data['email'],
		                f"Login\nUUID: {green}{data['login']['uuid']}{white}\nUsername: {green}{data['login']['username']}{white}\nPassword: {red}{data['login']['password']}{white}\nSALT: {red}{data['login']['salt']}{white}\nMD5: {green}{data['login']['md5']}{white}\nSHA1: {green}{data['login']['sha1']}{white}\nSHA256": data['login']['sha256'],
		                f"ID\nName: {green}{data['id']['name']}{white}\nValue": data['id']['value'], 
		    }
		    print(f"\n{white}{data['name']['first']} {data['name']['last']}{reset}")
		    for key, value in info.items():
		    	print(f"{white}├─ {key}: {green}{value}{reset}")
		    print(f"{white}-{reset}"*100)

start = datetime.now()		    
parser = argparse.ArgumentParser(description=f"{green}Rug{white}: A free, open-source tool for generating random user data. Like {green}Lorem Ipsum{white}, but for people. Developed by {green}Richard Mwewa{white} | https://github.com/{green}rlyonheart{reset}")
parser.add_argument("-r","--results",help=f"{white}results count ({green}default is 10{white}){reset}", metavar=f"{white}[NUMBER]{reset}", dest="results", default=10)
parser.add_argument("-n", "--nationality", help=f"{white}specify nationalit(y)(ies). If more than one, they ahould be seperated by a coma({green}es{white}, {green}gb{white}, {green}af{white}, {green}us{white}, {green}eu{white}). Default takes all available nationalities{reset}", metavar=f"{white}[NATIONALIT(Y)(IES)]{reset}", dest="nationality", default="es,gb,af,us,eu")
parser.add_argument("-v", "--verbose", help=f"{white}run Rug in {green}verbose{white} mode({green}show network logs,errors, and notices{white}){reset}", dest="verbose", action="store_true")
args = parser.parse_args()
if args.verbose:
		logging.basicConfig(format=f"{white}[{green}*{white}] %(message)s{reset}",level=logging.DEBUG)

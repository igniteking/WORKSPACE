import webbrowser

socialMediaUrls = ["www.facebook.com", "www.instagram.com"]

def open_tabs(url_list):
    for url in url_list:
        webbrowser.open_new_tab(url)
def main():
    webbrowser.open("www.youtube.com", new=2, autoraise=False)
    open_tabs(socialMediaUrls)
    time.sleep(1)
main()    